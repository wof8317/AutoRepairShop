/*
===========================================================================

Copyright (C) 2021 Felipe Woods.

This program is free software; you can redistribute it
and/or modify it under the terms of the GNU General Public License as
published by the Free Software Foundation; either version 3 of the License,
or (at your option) any later version.

This program is distributed in the hope that it will be
useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, see <http://www.gnu.org/licenses/>.

===========================================================================
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRepairShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Make sure to fill in the Labor and parts text boxes in case the user
            //doesn't fill it in
            if (txtParts.Text == "")
            {
                txtParts.Text = "0";
            }
            if (txtLabor.Text == "")
            {
                txtLabor.Text = "0";
            }

            //Initialize variables for the Oil and Lube Group
            double OilLubeCharges;
            double lube = 18;
            double oil = 26;
            //Determine what value should be stored in OilLubeCharges
            if (chkBxOil.Checked && chkBxLube.Checked)
            {
                OilLubeCharges = lube + oil;
            }
            else if (chkBxOil.Checked && !chkBxLube.Checked)
            {
                OilLubeCharges = oil;
            }
            else if (!chkBxOil.Checked && chkBxLube.Checked)
            {
                OilLubeCharges = lube;
            }
            else
            {
                OilLubeCharges = 0;
            }

            //Initialize variables for Flushes group
            double FlushCharges;
            double RadiatorFlush = 30;
            double TransmissionFlush = 80;
            //Determine what value should be stored in FlushCharges
            if (chkBxRadiator.Checked && chkBxTransmission.Checked)
            {
                FlushCharges = RadiatorFlush + TransmissionFlush;
            }
            else if (chkBxRadiator.Checked && !chkBxTransmission.Checked)
            {
                FlushCharges = RadiatorFlush;
            }
            else if (!chkBxRadiator.Checked && chkBxTransmission.Checked)
            {
                FlushCharges = TransmissionFlush;
            }
            else
            {
                FlushCharges = 0;
            }

            //Initialize variables for Misc Charges group
            double MiscCharges;
            double Inspection = 15;
            double MufflerReplacement = 100;
            double TireRotation = 20;
            //Determine what value should be stored in MiscCharges
            if (chkBxInspection.Checked && chkBxMuffler.Checked && chkBxTireRotation.Checked)
            {
                MiscCharges = Inspection + MufflerReplacement + TireRotation;
            }
            else if (chkBxInspection.Checked && chkBxMuffler.Checked && !chkBxTireRotation.Checked)
            {
                MiscCharges = Inspection + MufflerReplacement;
            }
            else if (chkBxInspection.Checked && !chkBxMuffler.Checked && chkBxTireRotation.Checked)
            {
                MiscCharges = Inspection + TireRotation;
            }
            else if (!chkBxInspection.Checked && chkBxMuffler.Checked && chkBxTireRotation.Checked)
            {
                MiscCharges = MufflerReplacement + TireRotation;
            }
            else if (chkBxInspection.Checked && !chkBxMuffler.Checked && !chkBxTireRotation.Checked)
            {
                MiscCharges = Inspection;
            }
            else if (!chkBxInspection.Checked && chkBxMuffler.Checked && !chkBxTireRotation.Checked)
            {
                MiscCharges = MufflerReplacement;
            }
            else if (!chkBxInspection.Checked && !chkBxMuffler.Checked && chkBxTireRotation.Checked)
            {
                MiscCharges = TireRotation;
            }
            else
            {
                MiscCharges = 0;
            }

            //Initialize Variables for Parts and Labor group
            double hrsLabor = Convert.ToDouble(txtLabor.Text);
            double Parts = Convert.ToDouble(txtParts.Text);
            double TotalParts = Parts;
            double LaborCharges = 29 * hrsLabor;
            double OtherCharges;
            //Determine what value should be stored in OtherCharges
            if (TotalParts != 0 && LaborCharges != 0)
            {
                OtherCharges = TotalParts + LaborCharges;
            }
            else if (TotalParts != 0 && LaborCharges == 0)
            {
                OtherCharges = TotalParts;
            }
            else if (TotalParts == 0 && LaborCharges != 0)
            {
                OtherCharges = LaborCharges;
            }
            else
            {
                OtherCharges = 0;
            }

            //Initialize variables and functions for the Summary group
            double ServicesAndLaborCharges;
            ServicesAndLaborCharges = OilLubeCharges + FlushCharges + MiscCharges + OtherCharges;
            double TaxCharges;
            //Determine whether taxes should be charged
            if (Parts != 0)
            {
                TaxCharges = Parts * 0.06;
            }
            else 
            {
                TaxCharges = 0;
            }
            //Second initalization of variables and functions for same group
            //but this time for calculating total fees
            double TotalCharges;
            TotalCharges = ServicesAndLaborCharges + TaxCharges;
            //Output results to the text boxes
            txtServicesAndLabor.Text = ServicesAndLaborCharges.ToString("c");
            txtSumParts.Text = Parts.ToString("c");
            txtTax.Text = TaxCharges.ToString("c");
            txtTotalFees.Text = TotalCharges.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear Everything
            chkBxOil.Checked = false;
            chkBxLube.Checked = false;
            chkBxMuffler.Checked = false;
            chkBxInspection.Checked = false;
            chkBxRadiator.Checked = false;
            chkBxTireRotation.Checked = false;
            chkBxTransmission.Checked = false;
            txtLabor.Clear();
            txtParts.Clear();
            txtServicesAndLabor.Clear();
            txtSumParts.Clear();
            txtTax.Clear();
            txtTotalFees.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This section of code was what I was working on, but couldn't figure out
        //so rather than getting rid of it, keep it here for historical value
        /*private void txtParts_Enter(object sender, EventArgs e)
        {
            if (txtParts.Text == "0")
            {
                txtParts.Text = "";
            }
        }

        private void txtParts_Leave(object sender, EventArgs e)
        {
            if (txtParts.Text == "")
            {
                txtParts.Text = "0";
            }
        }

        private void txtLabor_Enter(object sender, EventArgs e)
        {
            if (txtLabor.Text == "0")
            {
                txtLabor.Text = "";
            }
        }

        private void txtLabor_Leave(object sender, EventArgs e)
        {
            if (txtLabor.Text == "")
            {
                txtLabor.Text = "0";
            }
        }*/
    }
}
