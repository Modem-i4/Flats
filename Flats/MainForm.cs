using Extreme.DataAnalysis;
using Extreme.Mathematics;
using Extreme.Mathematics.LinearAlgebra;
using Extreme.Statistics;
using Flats.Core;
using Flats.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flats
{
    public partial class MainForm : Form
    {
        private FlatsRepository flatsRepos = new FlatsRepository();
        private ModelsRepository modelsRepos = new ModelsRepository();
        public MainForm()
        {
            InitializeComponent();
            var flats = flatsRepos.GetAll();
            if (flats != null)
                dataGridViewDefault.DataSource = flats;
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Flats data(*.csv)|*.csv";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                using (var sr = new StreamReader(ofd.FileName))
                {
                    string line = sr.ReadLine();
                    try
                    {
                        flatsRepos.CleanData();
                        while ((line = sr.ReadLine()) != null)
                        {
                            var vals = line.Split(',');
                            flatsRepos.Add(new Flat
                            {
                                SalePrice = int.Parse(vals[0]),
                                AgeSold = int.Parse(vals[2]) - int.Parse(vals[1]),
                                Size = int.Parse(vals[4]),
                                Floor = int.Parse(vals[5]),
                                HallwayType = vals[6] == "terraced" ? HallwayType.terraced : HallwayType.corridor,
                                HeatingType = vals[7] == "individual_heating" ? HeatingType.individual_heating : HeatingType.central_heating,
                                AptManageType = vals[8] == "management_in_trust" ? AptManageType.management_in_trust : AptManageType.self_management,
                                N_ParkinglotGround = int.Parse(vals[9].Replace(".0", "")),
                                N_ParkinglotBasement = int.Parse(vals[10].Replace(".0", "")),
                                TimeToBusStop = TimeTextToEnum(vals[11]),
                                TimeToSubway = TimeTextToEnum(vals[12]),
                                N_APT = int.Parse(vals[13].Replace(".0", "")),
                                N_manager = int.Parse(vals[14].Replace(".0", "")),
                                N_elevators = int.Parse(vals[15].Replace(".0", "")),
                                N_PublicOffice = int.Parse(vals[17].Replace(".0", "")),
                                N_Hospital = int.Parse(vals[18].Replace(".0", "")),
                                N_Dpartmentstore = int.Parse(vals[19].Replace(".0", "")),
                                N_Mall = int.Parse(vals[20].Replace(".0", "")),
                                N_ETC = int.Parse(vals[21].Replace(".0", "")),
                                N_Park = int.Parse(vals[22].Replace(".0", "")),
                                N_FacilitiesInApt = int.Parse(vals[27].Replace(".0", "")),
                                N_SchoolNearBy = int.Parse(vals[29].Replace(".0", "")),
                            });
                        }
                        TimeToPoint TimeTextToEnum(string time)
                        {
                            switch (time.Replace('-','~'))
                            {
                                case "0~5min":
                                    return TimeToPoint.min0_5;
                                case "5min~10min":
                                    return TimeToPoint.min5_10;
                                case "10min~15min":
                                    return TimeToPoint.min10_15;
                                case "15min~20min":
                                    return TimeToPoint.min15_20;
                                default:
                                    return TimeToPoint.no_point;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"failed to read line \"{line}\"");
                    }
                    dataGridViewDefault.DataSource = flatsRepos.GetAll();
                }
            }
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            Model newModel = new Model();
            string formula = "SalePrice ~ " + string.Join(" + ", typeof(Flat).GetProperties()
                .Where(o => o.Name != "Id" && o.Name != "SalePrice").Select(o => o.Name).ToArray());
            string[] stats = null;
            Extreme.DataAnalysis.Models.RegressionModel regression = null;
            switch (comboBoxModels.Text)
            {
                case "Linear regression":
                    newModel.Name = "Linear regression";
                    LinearRegressionModel model1 = new LinearRegressionModel(DataFrame.FromDataTable(flatsRepos.GetDataFrame()), formula);
                    model1.Fit();

                    newModel.ResidualStandardError = model1.StandardError;
                    newModel.RSquared = model1.RSquared;
                    newModel.AdjustedRSquared = model1.AdjustedRSquared;
                    newModel.FStatistic = model1.FStatistic;
                    newModel.CorrespondingPValue = model1.PValue;

                    stats = new string[]
                    {
                        $"Residual standard error:   {model1.StandardError:f2}",
                        $"R-Squared:   {model1.RSquared:f2}",
                        $"Adjusted R-Squared:   {model1.AdjustedRSquared:f2}",
                        $"F-statistic:   {model1.FStatistic:f2}",
                        $"Corresponding p-value:   {model1.PValue:f2}"
                    };
                    regression = model1;
                    break;
                /* case "Logistic regression":
                    LogisticRegressionModel model2 = new LogisticRegressionModel(DataFrame.FromDataTable(flatsRepos.GetDataFrame()), formula);
                    model2.Compute();

                    Extreme.Statistics.Tests.SimpleHypothesisTest lrt = model2.GetLikelihoodRatioTest();
                    newModel.LogLikehood = model2.LogLikelihood;
                    newModel.ChiSquared = lrt.Statistic;
                    newModel.CorrespondingPValue = lrt.PValue;

                    stats = new string[]
                    {
                        $"Log-likelihood:   {model2.LogLikelihood:f2}",
                        $"Chi-Squared:   {lrt.Statistic:f2}",
                        $"P-Value:   {lrt.PValue:f2}"
                    };
                    //regression = model2;
                    break;*/
                case "Generalized linear regression":
                    newModel.Name = "Generalized linear regression: " + comboBoxGeneralizedType.Text;
                    GeneralizedLinearModel model3 = new GeneralizedLinearModel(DataFrame.FromDataTable(flatsRepos.GetDataFrame()), formula);
                    switch (comboBoxGeneralizedType.Text)
                    {
                        case "Binomial":
                            model3.ModelFamily = ModelFamily.Binomial;
                            break;
                        case "InverseGaussian":
                            model3.ModelFamily = ModelFamily.InverseGaussian;
                            break;
                        case "Normal":
                            model3.ModelFamily = ModelFamily.Normal;
                            break;
                        case "Poisson":
                            model3.ModelFamily = ModelFamily.Poisson;
                            break;
                        default:
                            break;
                    }
                    model3.Fit();

                    newModel.LogLikehood = model3.LogLikelihood;
                    newModel.KernelLogLikehood = model3.GetKernelLogLikelihood();
                    newModel.Akaike = model3.GetAkaikeInformationCriterion();
                    newModel.CorrectedAIC = model3.GetCorrectedAkaikeInformationCriterion();
                    newModel.Bayesian = model3.GetBayesianInformationCriterion();
                    newModel.ChiSquared = model3.GetChiSquare();
                    if(comboBoxGeneralizedType.Text == "Normal" || comboBoxGeneralizedType.Text == "Poisson")
                    {
                        stats = new string[]
                        {
                        $"Log likelihood   {model3.LogLikelihood:f2}",
                        $"Kernel log likelihood::   {model3.GetKernelLogLikelihood():f2}",
                        $"Akaike (AIC):   {model3.GetAkaikeInformationCriterion():f2}",
                        $"Corrected AIC:   {model3.GetCorrectedAkaikeInformationCriterion():f2}",
                        $"Bayesian (BIC):   { model3.GetBayesianInformationCriterion():f2}",
                        $"Chi Square:   { model3.GetChiSquare():f2}"
                        };
                    }
                    regression = model3;
                    break;
            }
            foreach (Parameter parameter in regression.Parameters)
            {
                typeof(Model).GetProperty(parameter.Name).SetValue(newModel, parameter.Value);
            }
            dataGridViewParams.DataSource = regression.Parameters.ToArray();
            dataGridViewParams.Columns[dataGridViewParams.Columns.Count - 1].Visible = false;
            listBoxStats.Items.Clear();
            if(stats != null)
                listBoxStats.Items.AddRange(stats);
            modelsRepos.Add(newModel);
        }

        private void comboBoxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAnalyze.Enabled = true;

            comboBoxGeneralizedType.Enabled = comboBoxModels.Text == "Generalized linear regression";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 2)
            {
                dataGridViewModels.DataSource = modelsRepos.GetAll();
                if (dataGridViewModels.Rows[0] != null)
                    dataGridViewModels.Rows[0].Selected = true;
            }
        }

        private void buttonViewChart_Click(object sender, EventArgs e)
        {
            ChartForm cf = new ChartForm((Model)dataGridViewModels.SelectedRows[0].DataBoundItem);
            cf.Show();
        }

        private void buttonCalculatePrice_Click(object sender, EventArgs e)
        {
            CalculatePrice cp = new CalculatePrice();
            cp.Show();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "export.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WordExporter.Export_Data_To_Word(dataGridViewParams, sfd.FileName);
            }
        }
    }
}
