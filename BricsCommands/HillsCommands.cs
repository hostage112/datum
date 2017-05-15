﻿using System;
using System.Text;
using System.Collections;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using SW = System.Windows.Forms;

//ODA
using Teigha.Runtime;
using Teigha.DatabaseServices;
using Teigha.Geometry;

//Bricsys
using Bricscad.ApplicationServices;
using Bricscad.Runtime;
using Bricscad.EditorInput;

[assembly: CommandClass(typeof(HillsCommands.HillsCommands))]
namespace HillsCommands
{
    public class HillsCommands
    {
        [CommandMethod("HLS_INFO")]
        public void info()
        {
            SW.MessageBox.Show("AE Hills Versioon: 13.05.2017\n");
        }

        [CommandMethod("QWE")]
        public void dimentioning()
        {
            try
            {
                QWE_command program = new QWE_command();
                program.run();
            }
            catch (System.Exception ex)
            {
                SW.MessageBox.Show("Viga\n" + ex.Message);
            }
        }

        [CommandMethod("aaa")]
        public void arm_table_sum()
        {
            try
            {
                SUM_command program = new SUM_command();
                program.run();
                program.output_local();
            }
            catch (System.Exception ex)
            {
                SW.MessageBox.Show("Viga\n" + ex.Message);
            }
        }

        [CommandMethod("CSV_SUM_MARKS")]
        public void csv_sum()
        {
            try
            {
                SUM_command program = new SUM_command();
                program.run();
                program.dump_csv();
            }
            catch (System.Exception ex)
            {
                SW.MessageBox.Show("Viga\n" + ex.Message);
            }
        }


        [CommandMethod("tee")]
        public void testing()
        {
            try
            {
                XML_testing program = new XML_testing();
                program.run();
            }
            catch (System.Exception ex)
            {
                SW.MessageBox.Show("Viga\n" + ex.Message);
            }
        }
    }
}