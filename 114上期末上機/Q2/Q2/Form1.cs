using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const decimal OIL_CHANGE = 780m;
            const decimal LUBE_JOB = 540m;
            const decimal RADIATOR_FLUSH = 900m;
            const decimal TRANSMISSION_FLUSH = 2400m;
            const decimal INSPECTION = 450m;
            const decimal MUFFLER_REPLACEMENT = 3000m;
            const decimal TIRE_ROTATION = 600m;

            const decimal LABOR_RATE_PER_HOUR = 600m;
            const decimal TAX_RATE = 0.06m;

        }
    }
}
// 機油與潤滑
private decimal OilLubeCharges()
{
    decimal total = 0m;
    if (chkOilChange.Checked) total += OIL_CHANGE;
    if (chkLubeJob.Checked) total += LUBE_JOB;
    return total;
}

// 清洗服務
private decimal FlushCharges()
{
    decimal total = 0m;
    if (chkRadiatorFlush.Checked) total += RADIATOR_FLUSH;
    if (chkTransmissionFlush.Checked) total += TRANSMISSION_FLUSH;
    return total;
}

// 其他服務
private decimal MiscCharges()
{
    decimal total = 0m;
    if (chkInspection.Checked) total += INSPECTION;
    if (chkMuffler.Checked) total += MUFFLER_REPLACEMENT;
    if (chkTireRotation.Checked) total += TIRE_ROTATION;
    return total;
}

// 零件與工時
private decimal OtherCharges(out decimal partsCost)
{
    decimal laborHours = 0m;
    decimal laborCost = 0m;
    partsCost = 0m;

    decimal.TryParse(txtParts.Text, out partsCost);
    decimal.TryParse(txtLaborHours.Text, out laborHours);

    laborCost = laborHours * LABOR_RATE_PER_HOUR;
    return laborCost;
}

// 稅金（只對零件）
private decimal TaxCharges(decimal partsCost)
{
    return partsCost * TAX_RATE;
}

// 總金額
private decimal TotalCharges(decimal serviceLabor, decimal parts, decimal tax)
{
    return serviceLabor + parts + tax;
}
private void calculateButton_Click(object sender, EventArgs e)
{
    decimal serviceCost =
        OilLubeCharges() +
        FlushCharges() +
        MiscCharges();

    decimal partsCost;
    decimal laborCost = OtherCharges(out partsCost);

    decimal serviceAndLabor = serviceCost + laborCost;
    decimal tax = TaxCharges(partsCost);
    decimal total = TotalCharges(serviceAndLabor, partsCost, tax);

    txtServiceLabor.Text = serviceAndLabor.ToString("C0");
    txtPartsTotal.Text = partsCost.ToString("C0");
    txtTax.Text = tax.ToString("C0");
    txtTotal.Text = total.ToString("C0");
}
private void ClearOilLube()
{
    chkOilChange.Checked = false;
    chkLubeJob.Checked = false;
}

private void ClearFlushes()
{
    chkRadiatorFlush.Checked = false;
    chkTransmissionFlush.Checked = false;
}

private void ClearMisc()
{
    chkInspection.Checked = false;
    chkMuffler.Checked = false;
    chkTireRotation.Checked = false;
}

private void ClearOther()
{
    txtParts.Text = "";
    txtLaborHours.Text = "";
}

private void ClearFees()
{
    txtServiceLabor.Text = "";
    txtPartsTotal.Text = "";
    txtTax.Text = "";
    txtTotal.Text = "";
}
private void clearButton_Click(object sender, EventArgs e)
{
    ClearOilLube();
    ClearFlushes();
    ClearMisc();
    ClearOther();
    ClearFees();
}
private void exitButton_Click(object sender, EventArgs e)
{
    if (MessageBox.Show("是否要離開程式？", "確認",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
        this.Close();
    }
}
