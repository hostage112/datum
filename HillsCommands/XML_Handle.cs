﻿#define BRX_APP
//#define ARX_APP

using System;
using System.Text;
using System.Collections;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using _SWF = System.Windows.Forms;


#if BRX_APP
    using _Ap = Bricscad.ApplicationServices;
    //using _Br = Teigha.BoundaryRepresentation;
    using _Cm = Teigha.Colors;
    using _Db = Teigha.DatabaseServices;
    using _Ed = Bricscad.EditorInput;
    using _Ge = Teigha.Geometry;
    using _Gi = Teigha.GraphicsInterface;
    using _Gs = Teigha.GraphicsSystem;
    using _Gsk = Bricscad.GraphicsSystem;
    using _Pl = Bricscad.PlottingServices;
    using _Brx = Bricscad.Runtime;
    using _Trx = Teigha.Runtime;
    using _Wnd = Bricscad.Windows;
    //using _Int = Bricscad.Internal;
#elif ARX_APP
    using _Ap = Autodesk.AutoCAD.ApplicationServices;
    //using _Br = Autodesk.AutoCAD.BoundaryRepresentation;
    using _Cm = Autodesk.AutoCAD.Colors;
    using _Db = Autodesk.AutoCAD.DatabaseServices;
    using _Ed = Autodesk.AutoCAD.EditorInput;
    using _Ge = Autodesk.AutoCAD.Geometry;
    using _Gi = Autodesk.AutoCAD.GraphicsInterface;
    using _Gs = Autodesk.AutoCAD.GraphicsSystem;
    using _Pl = Autodesk.AutoCAD.PlottingServices;
    using _Brx = Autodesk.AutoCAD.Runtime;
    using _Trx = Autodesk.AutoCAD.Runtime;
    using _Wnd = Autodesk.AutoCAD.Windows;
#endif

using System.Xml;


namespace commands
{
    static class XML_Handle
    {
        public static string getXMLRebarString(XmlNode rebar)
        {
            string result = "";

            string type = emptyNodehandle(rebar, "Type");

            string pos_nr = "Pos: [" + emptyNodehandle(rebar, "Litt") + "]";
            string diam = "Diameter: [" + emptyNodehandle(rebar, "Dim") + "]";
            string length = "Length: [" + emptyNodehandle(rebar, "Length") + "]";
            XmlNode geometry = rebar["B2aGeometry"];

            result = "Type [" + type + "]" + " - " + pos_nr + " - " + diam + " - " + length;

            if (type == "A")
            {

            }
            else
            {
                if (geometry == null)
                {
                    result = result + " - [NO GEOMETRY]";
                }
                else
                {
                    if (type == "B")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + r;
                    }
                    else if (type == "C")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + r;
                    }
                    else if (type == "D")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + v + " - " + r;
                    }
                    else if (type == "E")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string u = "U: [" + emptyNodehandle(geometry, "U") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + v + " - " + u + " - " + r;
                    }
                    else if (type == "EX")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: *[" + emptyNodehandle(geometry, "B") + "]*";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string y = "Y: [" + emptyNodehandle(geometry, "Y") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string u = "U: *[" + emptyNodehandle(geometry, "U") + "]*";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + y + " - " + v + " - " + u + " - " + r;
                    }
                    else if (type == "F")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + v + " - " + r;
                    }
                    else if (type == "G")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: *[" + emptyNodehandle(geometry, "B") + "]*";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string x = "X: [" + emptyNodehandle(geometry, "X") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string s = "S: [" + emptyNodehandle(geometry, "S") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + x + " - " + v + " - " + s + " - " + r;
                    }
                    else if (type == "H")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: *[" + emptyNodehandle(geometry, "C") + "]*";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string e = "E: [" + emptyNodehandle(geometry, "E") + "]";
                        string x = "X: [" + emptyNodehandle(geometry, "X") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string s = "S: [" + emptyNodehandle(geometry, "S") + "]";
                        string u = "U: [" + emptyNodehandle(geometry, "U") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + e + " - " + x + " - " + v + " - " + s + " - " + u + " - " + r;
                    }
                    else if (type == "J")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: *[" + emptyNodehandle(geometry, "B") + "]*";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string d = "D: *[" + emptyNodehandle(geometry, "D") + "]*";
                        string e = "E: [" + emptyNodehandle(geometry, "E") + "]";
                        string x = "X: [" + emptyNodehandle(geometry, "X") + "]";
                        string y = "Y: [" + emptyNodehandle(geometry, "Y") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string s = "S: [" + emptyNodehandle(geometry, "S") + "]";
                        string t = "T: [" + emptyNodehandle(geometry, "T") + "]";
                        string u = "U: [" + emptyNodehandle(geometry, "U") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + e + " - " + x + " - " + y + " - " + v + " - " + s + " - " + t + " - " + u + " - " + r;
                    }
                    else if (type == "K")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + r;
                    }
                    else if (type == "L")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string e = "E: [" + emptyNodehandle(geometry, "E") + "]";
                        string f = "F: [" + emptyNodehandle(geometry, "F") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + e + " - " + f + " - " + r;
                    }
                    else if (type == "LX")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: *[" + emptyNodehandle(geometry, "C") + "]*";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string e = "E: [" + emptyNodehandle(geometry, "E") + "]";
                        string x = "X: [" + emptyNodehandle(geometry, "X") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string s = "S: [" + emptyNodehandle(geometry, "S") + "]";
                        string t = "T: *[" + emptyNodehandle(geometry, "T") + "]*";
                        string u = "U: [" + emptyNodehandle(geometry, "U") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + e + " - " + x + " - " + v + " - " + s + " - " + t + " - " + u + " - " + r;
                    }
                    else if (type == "M")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: *[" + emptyNodehandle(geometry, "C") + "]*";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string e = "E: *[" + emptyNodehandle(geometry, "E") + "]*";
                        string f = "F: [" + emptyNodehandle(geometry, "F") + "]";
                        string g = "G: [" + emptyNodehandle(geometry, "G") + "]";
                        string x = "X: [" + emptyNodehandle(geometry, "X") + "]";
                        string y = "Y: [" + emptyNodehandle(geometry, "Y") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string s = "S: [" + emptyNodehandle(geometry, "S") + "]";
                        string t = "T: [" + emptyNodehandle(geometry, "T") + "]";
                        string u = "U: [" + emptyNodehandle(geometry, "U") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + e + " - " + f + " - " + g + " - " + x + " - " + y + " - " + v + " - " + s + " - " + t + " - " + u + " - " + r;
                    }
                    else if (type == "N")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";
                        string end1 = "End1: [" + emptyNodehandle(geometry, "End1") + "]";
                        string end2 = "End2: [" + emptyNodehandle(geometry, "End2") + "]";

                        result = result + " - " + a + " - " + b + " - " + r + " - " + end1 + " - " + end2;

                    }
                    else if (type == "NX")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: *[" + emptyNodehandle(geometry, "B") + "]*";
                        string c = "C: *[" + emptyNodehandle(geometry, "C") + "]*";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string u = "U: *[" + emptyNodehandle(geometry, "U") + "]*";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        string end1 = "End1: [" + emptyNodehandle(geometry, "End1") + "]";
                        string end2 = "End2: [" + emptyNodehandle(geometry, "End2") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + v + " - " + u + " - " + r + " - " + end1 + " - " + end2;
                    }
                    else if (type == "O")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string x = "X: [" + emptyNodehandle(geometry, "X") + "]";
                        string y = "Y: [" + emptyNodehandle(geometry, "Y") + "]";

                        result = result + " - " + a + " - " + x + " - " + y;
                    }
                    else if (type == "Q")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string x = "X: [" + emptyNodehandle(geometry, "X") + "]";

                        result = result + " - " + a + " - " + x;
                    }
                    else if (type == "R")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: *[" + emptyNodehandle(geometry, "B") + "]*";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string y = "Y: [" + emptyNodehandle(geometry, "Y") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + y + " - " + r;
                    }
                    else if (type == "S")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string y = "Y: [" + emptyNodehandle(geometry, "Y") + "]";

                        result = result + " - " + a + " - " + b + " - " + y;
                    }
                    else if (type == "SH")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string y = "Y: [" + emptyNodehandle(geometry, "Y") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + y + " - " + r;
                    }
                    else if (type == "SX")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string y = "Y: [" + emptyNodehandle(geometry, "Y") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + y + " - " + v + " - " + r;
                    }
                    else if (type == "T")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string e = "E: [" + emptyNodehandle(geometry, "E") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + e + " - " + r;
                    }
                    else if (type == "U")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: *[" + emptyNodehandle(geometry, "B") + "]*";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string x = "X: [" + emptyNodehandle(geometry, "X") + "]";
                        string y = "Y: [" + emptyNodehandle(geometry, "Y") + "]";
                        string v = "V: *[" + emptyNodehandle(geometry, "V") + "]*";
                        string u = "U: *[" + emptyNodehandle(geometry, "U") + "]*";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        string end1 = "End1: [" + emptyNodehandle(geometry, "End1") + "]";
                        string end2 = "End2: [" + emptyNodehandle(geometry, "End2") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + x + " - " + y + " - " + v + " - " + u + " - " + r + " - " + end1 + " - " + end2;
                    }
                    else if (type == "V")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: *[" + emptyNodehandle(geometry, "B") + "]*";
                        string x = "X: [" + emptyNodehandle(geometry, "X") + "]";
                        string y = "Y: [" + emptyNodehandle(geometry, "Y") + "]";
                        string v = "V: *[" + emptyNodehandle(geometry, "V") + "]*";
                        string u = "U: *[" + emptyNodehandle(geometry, "U") + "]*";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        string end1 = "End1: [" + emptyNodehandle(geometry, "End1") + "]";
                        string end2 = "End2: [" + emptyNodehandle(geometry, "End2") + "]";

                        result = result + " - " + a + " - " + b + " - " + x + " - " + y + " - " + v + " - " + u + " - " + r + " - " + end1 + " - " + end2;
                    }
                    else if (type == "W")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: *[" + emptyNodehandle(geometry, "C") + "]*";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string e = "E: [" + emptyNodehandle(geometry, "E") + "]";
                        string x = "X: [" + emptyNodehandle(geometry, "X") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string u = "U: *[" + emptyNodehandle(geometry, "U") + "]*";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + e + " - " + x + " - " + v + " - " + u + " - " + r;
                    }
                    else if (type == "X")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string e = "E: [" + emptyNodehandle(geometry, "E") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + e + " - " + v + " - " + r;
                    }
                    else if (type == "XX")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string e = "E: [" + emptyNodehandle(geometry, "E") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + e + " - " + v + " - " + r;
                    }
                    else if (type == "Z")
                    {
                        string a = "A: [" + emptyNodehandle(geometry, "A") + "]";
                        string b = "B: [" + emptyNodehandle(geometry, "B") + "]";
                        string c = "C: [" + emptyNodehandle(geometry, "C") + "]";
                        string d = "D: [" + emptyNodehandle(geometry, "D") + "]";
                        string v = "V: [" + emptyNodehandle(geometry, "V") + "]";
                        string r = "R: [" + emptyNodehandle(geometry, "R") + "]";

                        result = result + " - " + a + " - " + b + " - " + c + " - " + d + " - " + v + " - " + r;
                    }
                }
            }

            return result;
        }


        private static void bendingRadiusHandle(_Mark undef, ref XmlNode r, _Ed.Editor ed)
        {
            if (undef.Diameter == 6 || undef.Diameter == 8 || undef.Diameter == 10)
            {
                r.InnerText = "12";
            }
            else if (undef.Diameter == 12 || undef.Diameter == 16)
            {
                r.InnerText = "24";
            }
            else if (undef.Diameter == 20)
            {
                r.InnerText = "32";
            }
            else if (undef.Diameter == 25)
            {
                r.InnerText = "64";
            }
            else
            {
                r.InnerText = prompt("R", ed);
            }
        }


        public static XmlNode newNodeHandle(_Mark undef, string materjal, XmlDocument xmlDoc, _Ed.Editor ed)
        {
            XmlNode row = xmlDoc.CreateElement("B2aPageRow");
            XmlAttribute attribute = xmlDoc.CreateAttribute("RowId");
            attribute.Value = "99";
            row.Attributes.Append(attribute);

            XmlNode group = xmlDoc.CreateElement("NoGrps");
            group.InnerText = "1";
            XmlNode count = xmlDoc.CreateElement("NoStpGrp");
            count.InnerText = "9999";
            XmlNode bar = xmlDoc.CreateElement("B2aBar");

            XmlNode type_node = xmlDoc.CreateElement("Type");
            type_node.InnerText = undef.Position_Shape;
            XmlNode pos = xmlDoc.CreateElement("Litt");
            pos.InnerText = undef.Position_Nr.ToString();
            XmlNode material = xmlDoc.CreateElement("fu01:B2aStlSorts");
            material.InnerText = materjal;
            XmlNode dim = xmlDoc.CreateElement("Dim");
            dim.InnerText = undef.Diameter.ToString();

            XmlNode geo = xmlDoc.CreateElement("B2aGeometry");

            string type = undef.Position_Shape;

            if (type == "A")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                a.InnerText = undef.Position_Nr.ToString();
                geo.AppendChild(a);
            }
            else if (type == "B")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(r);
            }
            else if (type == "C")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                c.InnerText = prompt("C", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(c);
                geo.AppendChild(r);
            }
            else if (type == "D")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                v.InnerText = prompt("V", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(v);
                geo.AppendChild(r);
            }
            else if (type == "E")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode u = xmlDoc.CreateElement("U");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                c.InnerText = prompt("C", ed);
                v.InnerText = prompt("V", ed);
                u.InnerText = prompt("U", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(c);
                geo.AppendChild(v);
                geo.AppendChild(u);
                geo.AppendChild(r);
            }
            else if (type == "EX")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode y = xmlDoc.CreateElement("Y");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                c.InnerText = prompt("C", ed);
                y.InnerText = prompt("Y", ed);
                v.InnerText = prompt("V", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(c);
                geo.AppendChild(y);
                geo.AppendChild(v);
                geo.AppendChild(r);
            }
            else if (type == "F")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                v.InnerText = prompt("V", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(v);
                geo.AppendChild(r);
            }
            else if (type == "G")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode x = xmlDoc.CreateElement("X");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode s = xmlDoc.CreateElement("S");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                c.InnerText = prompt("C", ed);
                x.InnerText = prompt("X", ed);
                v.InnerText = prompt("V", ed);
                s.InnerText = prompt("S", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(c);
                geo.AppendChild(x);
                geo.AppendChild(v);
                geo.AppendChild(s);
                geo.AppendChild(r);
            }
            else if (type == "H")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode e = xmlDoc.CreateElement("E");
                XmlNode x = xmlDoc.CreateElement("X");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode s = xmlDoc.CreateElement("S");
                XmlNode u = xmlDoc.CreateElement("U");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                d.InnerText = prompt("D", ed);
                e.InnerText = prompt("E", ed);
                x.InnerText = prompt("X", ed);
                v.InnerText = prompt("V", ed);
                s.InnerText = prompt("S", ed);
                u.InnerText = prompt("U", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(d);
                geo.AppendChild(e);
                geo.AppendChild(x);
                geo.AppendChild(v);
                geo.AppendChild(s);
                geo.AppendChild(u);
                geo.AppendChild(r);
            }
            else if (type == "J")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode e = xmlDoc.CreateElement("E");
                XmlNode x = xmlDoc.CreateElement("X");
                XmlNode y = xmlDoc.CreateElement("Y");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode s = xmlDoc.CreateElement("S");
                XmlNode t = xmlDoc.CreateElement("T");
                XmlNode u = xmlDoc.CreateElement("U");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                c.InnerText = prompt("C", ed);
                e.InnerText = prompt("E", ed);
                x.InnerText = prompt("X", ed);
                y.InnerText = prompt("Y", ed);
                v.InnerText = prompt("V", ed);
                s.InnerText = prompt("S", ed);
                t.InnerText = prompt("T", ed);
                u.InnerText = prompt("U", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(c);
                geo.AppendChild(e);
                geo.AppendChild(x);
                geo.AppendChild(y);
                geo.AppendChild(v);
                geo.AppendChild(s);
                geo.AppendChild(t);
                geo.AppendChild(u);
                geo.AppendChild(r);
            }
            else if (type == "K")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                c.InnerText = prompt("C", ed);
                d.InnerText = prompt("D", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(c);
                geo.AppendChild(d);
                geo.AppendChild(r);
            }
            else if (type == "L")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode e = xmlDoc.CreateElement("E");
                XmlNode f = xmlDoc.CreateElement("F");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                c.InnerText = prompt("C", ed);
                d.InnerText = prompt("D", ed);
                e.InnerText = prompt("E", ed);
                f.InnerText = prompt("F", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(c);
                geo.AppendChild(d);
                geo.AppendChild(e);
                geo.AppendChild(f);
                geo.AppendChild(r);
            }
            else if (type == "LX")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode e = xmlDoc.CreateElement("E");
                XmlNode x = xmlDoc.CreateElement("X");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode s = xmlDoc.CreateElement("S");
                XmlNode u = xmlDoc.CreateElement("U");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                d.InnerText = prompt("D", ed);
                e.InnerText = prompt("E", ed);
                x.InnerText = prompt("X", ed);
                v.InnerText = prompt("V", ed);
                s.InnerText = prompt("S", ed);
                u.InnerText = prompt("U", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(d);
                geo.AppendChild(e);
                geo.AppendChild(x);
                geo.AppendChild(v);
                geo.AppendChild(s);
                geo.AppendChild(u);
                geo.AppendChild(r);
            }
            else if (type == "M")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode f = xmlDoc.CreateElement("F");
                XmlNode g = xmlDoc.CreateElement("G");
                XmlNode x = xmlDoc.CreateElement("X");
                XmlNode y = xmlDoc.CreateElement("Y");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode s = xmlDoc.CreateElement("S");
                XmlNode t = xmlDoc.CreateElement("T");
                XmlNode u = xmlDoc.CreateElement("U");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                d.InnerText = prompt("D", ed);
                f.InnerText = prompt("F", ed);
                g.InnerText = prompt("G", ed);
                x.InnerText = prompt("X", ed);
                y.InnerText = prompt("Y", ed);
                v.InnerText = prompt("V", ed);
                s.InnerText = prompt("S", ed);
                t.InnerText = prompt("T", ed);
                u.InnerText = prompt("U", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(d);
                geo.AppendChild(f);
                geo.AppendChild(g);
                geo.AppendChild(x);
                geo.AppendChild(y);
                geo.AppendChild(v);
                geo.AppendChild(s);
                geo.AppendChild(t);
                geo.AppendChild(u);
                geo.AppendChild(r);
            }
            else if (type == "N")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode r = xmlDoc.CreateElement("R");
                XmlNode e1 = xmlDoc.CreateElement("End1");
                XmlNode e2 = xmlDoc.CreateElement("End2");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                bendingRadiusHandle(undef, ref r, ed);
                e1.InnerText = "L";
                e2.InnerText = "L";

                geo.AppendChild(e1);
                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(e2);
                geo.AppendChild(r);
            }
            else if (type == "NX")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode r = xmlDoc.CreateElement("R");
                XmlNode e1 = xmlDoc.CreateElement("End1");
                XmlNode e2 = xmlDoc.CreateElement("End2");

                a.InnerText = prompt("A", ed);
                d.InnerText = prompt("D", ed);
                v.InnerText = prompt("V", ed);
                bendingRadiusHandle(undef, ref r, ed);
                e1.InnerText = "L";
                e2.InnerText = "L";

                geo.AppendChild(e1);
                geo.AppendChild(a);
                geo.AppendChild(d);
                geo.AppendChild(e2);
                geo.AppendChild(v);
                geo.AppendChild(r);
            }
            else if (type == "O")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode x = xmlDoc.CreateElement("X");
                XmlNode y = xmlDoc.CreateElement("Y");

                a.InnerText = prompt("A", ed);
                x.InnerText = prompt("X", ed);
                y.InnerText = prompt("Y", ed);

                geo.AppendChild(a);
                geo.AppendChild(x);
                geo.AppendChild(y);
            }
            else if (type == "Q")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode x = xmlDoc.CreateElement("X");

                a.InnerText = prompt("A", ed);
                x.InnerText = prompt("X", ed);

                geo.AppendChild(a);
                geo.AppendChild(x);
            }
            else if (type == "R")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode y = xmlDoc.CreateElement("Y");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                c.InnerText = prompt("C", ed);
                d.InnerText = prompt("D", ed);
                y.InnerText = prompt("Y", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(c);
                geo.AppendChild(d);
                geo.AppendChild(y);
                geo.AppendChild(r);
            }
            else if (type == "S")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode y = xmlDoc.CreateElement("Y");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                y.InnerText = prompt("Y", ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(y);
            }
            else if (type == "SH")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode y = xmlDoc.CreateElement("Y");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                c.InnerText = prompt("C", ed);
                d.InnerText = prompt("D", ed);
                y.InnerText = prompt("Y", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(c);
                geo.AppendChild(d);
                geo.AppendChild(y);
                geo.AppendChild(r);
            }
            else if (type == "SX")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode y = xmlDoc.CreateElement("Y");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                c.InnerText = prompt("C", ed);
                d.InnerText = prompt("D", ed);
                y.InnerText = prompt("Y", ed);
                v.InnerText = prompt("V", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(c);
                geo.AppendChild(d);
                geo.AppendChild(y);
                geo.AppendChild(v);
                geo.AppendChild(r);
            }
            else if (type == "T")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode e = xmlDoc.CreateElement("E");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                c.InnerText = prompt("C", ed);
                d.InnerText = prompt("D", ed);
                e.InnerText = prompt("E", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(c);
                geo.AppendChild(d);
                geo.AppendChild(e);
                geo.AppendChild(r);
            }
            else if (type == "U")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode x = xmlDoc.CreateElement("X");
                XmlNode y = xmlDoc.CreateElement("Y");
                XmlNode r = xmlDoc.CreateElement("R");
                XmlNode e1 = xmlDoc.CreateElement("End1");
                XmlNode e2 = xmlDoc.CreateElement("End2");

                a.InnerText = prompt("A", ed);
                c.InnerText = prompt("C", ed);
                x.InnerText = prompt("X", ed);
                y.InnerText = prompt("Y", ed);
                bendingRadiusHandle(undef, ref r, ed);
                e1.InnerText = "L";
                e2.InnerText = "L";

                geo.AppendChild(e1);
                geo.AppendChild(a);
                geo.AppendChild(c);
                geo.AppendChild(e2);
                geo.AppendChild(x);
                geo.AppendChild(y);
                geo.AppendChild(r);
            }
            else if (type == "V")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode x = xmlDoc.CreateElement("X");
                XmlNode y = xmlDoc.CreateElement("Y");
                XmlNode r = xmlDoc.CreateElement("R");
                XmlNode e1 = xmlDoc.CreateElement("End1");
                XmlNode e2 = xmlDoc.CreateElement("End2");

                a.InnerText = prompt("A", ed);
                x.InnerText = prompt("X", ed);
                y.InnerText = prompt("Y", ed);
                bendingRadiusHandle(undef, ref r, ed);
                e1.InnerText = "L";
                e2.InnerText = "L";

                geo.AppendChild(e1);
                geo.AppendChild(a);
                geo.AppendChild(e2);
                geo.AppendChild(x);
                geo.AppendChild(y);
                geo.AppendChild(r);
            }
            else if (type == "W")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode e = xmlDoc.CreateElement("E");
                XmlNode x = xmlDoc.CreateElement("X");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                d.InnerText = prompt("D", ed);
                e.InnerText = prompt("E", ed);
                x.InnerText = prompt("X", ed);
                v.InnerText = prompt("V", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(d);
                geo.AppendChild(e);
                geo.AppendChild(x);
                geo.AppendChild(v);
                geo.AppendChild(r);
            }
            else if (type == "X")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode e = xmlDoc.CreateElement("E");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                c.InnerText = prompt("C", ed);
                d.InnerText = prompt("D", ed);
                e.InnerText = prompt("E", ed);
                v.InnerText = prompt("V", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(c);
                geo.AppendChild(d);
                geo.AppendChild(e);
                geo.AppendChild(v);
                geo.AppendChild(r);
            }
            else if (type == "XX")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode e = xmlDoc.CreateElement("E");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                c.InnerText = prompt("C", ed);
                d.InnerText = prompt("D", ed);
                e.InnerText = prompt("E", ed);
                v.InnerText = prompt("V", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(c);
                geo.AppendChild(d);
                geo.AppendChild(e);
                geo.AppendChild(v);
                geo.AppendChild(r);
            }
            else if (type == "Z")
            {
                XmlNode a = xmlDoc.CreateElement("A");
                XmlNode b = xmlDoc.CreateElement("B");
                XmlNode c = xmlDoc.CreateElement("C");
                XmlNode d = xmlDoc.CreateElement("D");
                XmlNode v = xmlDoc.CreateElement("V");
                XmlNode r = xmlDoc.CreateElement("R");

                a.InnerText = prompt("A", ed);
                b.InnerText = prompt("B", ed);
                c.InnerText = prompt("C", ed);
                d.InnerText = prompt("D", ed);
                v.InnerText = prompt("V", ed);
                bendingRadiusHandle(undef, ref r, ed);

                geo.AppendChild(a);
                geo.AppendChild(b);
                geo.AppendChild(c);
                geo.AppendChild(d);
                geo.AppendChild(v);
                geo.AppendChild(r);
            }

            bar.AppendChild(type_node);
            bar.AppendChild(pos);
            bar.AppendChild(material);
            bar.AppendChild(dim);
            bar.AppendChild(geo);

            row.AppendChild(group);
            row.AppendChild(count);
            row.AppendChild(bar);

            return row;
        }


        public static List<XmlNode> findSimilar(XmlNode newReb, List<XmlNode> rebars)
        {
            List<XmlNode> similar = new List<XmlNode>();

            XmlNode dummy = newReb["B2aBar"];
            XmlNode dummy_geometry = dummy["B2aGeometry"];

            string dummy_dim = emptyNodehandle(dummy, "Dim");
            string dummy_type = dummy["Type"].InnerText;

            foreach (XmlNode rebar in rebars)
            {
                bool found = true;

                XmlNode existing = rebar["B2aBar"];
                if (existing == null) continue;

                string dim = emptyNodehandle(existing, "Dim");
                if (dummy_dim != "???" && dim != "???" && dummy_dim != dim) continue;

                XmlNode existing_geometry = existing["B2aGeometry"];

                if (existing_geometry == null)
                {
                    similar.Add(rebar);
                    continue;
                }

                if (dummy_type == "B")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;

                    if (found == false)
                    {
                        found = true;
                        if (new_a != "???" && old_b != "???" && new_a != old_b) found = false;
                        if (new_b != "???" && old_a != "???" && new_b != old_a) found = false;
                    }

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "C")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;

                    if (found == false)
                    {
                        found = true;
                        if (new_a != "???" && old_c != "???" && new_a != old_c) found = false;
                        if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                        if (new_c != "???" && old_a != "???" && new_c != old_a) found = false;
                    }

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "D")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found == false)
                    {
                        found = true;
                        if (new_a != "???" && old_b != "???" && new_a != old_b) found = false;
                        if (new_b != "???" && old_a != "???" && new_b != old_a) found = false;
                        if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    }

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "E")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_v = emptyNodehandle(existing_geometry, "V");
                    string old_u = emptyNodehandle(existing_geometry, "U");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_v = emptyNodehandle(dummy_geometry, "V");
                    string new_u = emptyNodehandle(dummy_geometry, "U");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    if (new_u != "???" && old_u != "???" && new_u != old_u) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "EX")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_y = emptyNodehandle(existing_geometry, "Y");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "F")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found == false)
                    {
                        found = true;
                        if (new_a != "???" && old_b != "???" && new_a != old_b) found = false;
                        if (new_b != "???" && old_a != "???" && new_b != old_a) found = false;
                        if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    }

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "G")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_v = emptyNodehandle(existing_geometry, "V");
                    string old_s = emptyNodehandle(existing_geometry, "S");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_v = emptyNodehandle(dummy_geometry, "V");
                    string new_s = emptyNodehandle(dummy_geometry, "S");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    if (new_s != "???" && old_s != "???" && new_s != old_s) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "H")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_v = emptyNodehandle(existing_geometry, "V");
                    string old_s = emptyNodehandle(existing_geometry, "S");
                    string old_u = emptyNodehandle(existing_geometry, "U");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_v = emptyNodehandle(dummy_geometry, "V");
                    string new_s = emptyNodehandle(dummy_geometry, "S");
                    string new_u = emptyNodehandle(dummy_geometry, "U");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    if (new_s != "???" && old_s != "???" && new_s != old_s) found = false;
                    if (new_u != "???" && old_u != "???" && new_u != old_u) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "J")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_y = emptyNodehandle(existing_geometry, "Y");
                    string old_v = emptyNodehandle(existing_geometry, "V");
                    string old_s = emptyNodehandle(existing_geometry, "S");
                    string old_t = emptyNodehandle(existing_geometry, "T");
                    string old_u = emptyNodehandle(existing_geometry, "U");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");
                    string new_v = emptyNodehandle(dummy_geometry, "V");
                    string new_s = emptyNodehandle(dummy_geometry, "S");
                    string new_t = emptyNodehandle(dummy_geometry, "T");
                    string new_u = emptyNodehandle(dummy_geometry, "U");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    if (new_s != "???" && old_s != "???" && new_s != old_s) found = false;
                    if (new_t != "???" && old_t != "???" && new_t != old_t) found = false;
                    if (new_u != "???" && old_u != "???" && new_u != old_u) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "K")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "L")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_f = emptyNodehandle(existing_geometry, "F");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_f = emptyNodehandle(dummy_geometry, "F");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_f != "???" && old_f != "???" && new_f != old_f) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "LX")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_v = emptyNodehandle(existing_geometry, "V");
                    string old_s = emptyNodehandle(existing_geometry, "S");
                    string old_u = emptyNodehandle(existing_geometry, "U");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_v = emptyNodehandle(dummy_geometry, "V");
                    string new_s = emptyNodehandle(dummy_geometry, "S");
                    string new_u = emptyNodehandle(dummy_geometry, "U");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    if (new_s != "???" && old_s != "???" && new_s != old_s) found = false;
                    if (new_u != "???" && old_u != "???" && new_u != old_u) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "M")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_f = emptyNodehandle(existing_geometry, "F");
                    string old_g = emptyNodehandle(existing_geometry, "G");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_y = emptyNodehandle(existing_geometry, "Y");
                    string old_v = emptyNodehandle(existing_geometry, "V");
                    string old_s = emptyNodehandle(existing_geometry, "S");
                    string old_t = emptyNodehandle(existing_geometry, "T");
                    string old_u = emptyNodehandle(existing_geometry, "U");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_f = emptyNodehandle(dummy_geometry, "F");
                    string new_g = emptyNodehandle(dummy_geometry, "G");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");
                    string new_v = emptyNodehandle(dummy_geometry, "V");
                    string new_s = emptyNodehandle(dummy_geometry, "S");
                    string new_t = emptyNodehandle(dummy_geometry, "T");
                    string new_u = emptyNodehandle(dummy_geometry, "U");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_f != "???" && old_f != "???" && new_f != old_f) found = false;
                    if (new_g != "???" && old_g != "???" && new_g != old_g) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    if (new_s != "???" && old_s != "???" && new_s != old_s) found = false;
                    if (new_t != "???" && old_t != "???" && new_t != old_t) found = false;
                    if (new_u != "???" && old_u != "???" && new_u != old_u) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "N")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;

                    if (found == false)
                    {
                        found = true;
                        if (new_a != "???" && old_b != "???" && new_a != old_b) found = false;
                        if (new_b != "???" && old_a != "???" && new_b != old_a) found = false;
                    }

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "NX")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "O")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_y = emptyNodehandle(existing_geometry, "Y");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "Q")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_x = emptyNodehandle(existing_geometry, "X");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_x = emptyNodehandle(dummy_geometry, "X");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "R")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_y = emptyNodehandle(existing_geometry, "Y");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;                    

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "S")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_y = emptyNodehandle(existing_geometry, "Y");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "SH")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_y = emptyNodehandle(existing_geometry, "Y");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "SX")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_y = emptyNodehandle(existing_geometry, "Y");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "T")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "U")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_y = emptyNodehandle(existing_geometry, "Y");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "V")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_y = emptyNodehandle(existing_geometry, "Y");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "W")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    
                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "X")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "XX")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "Z")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
            }

            return similar;
        }


        public static List<XmlNode> findSimilarTolerance(XmlNode newReb, List<XmlNode> rebars, double TOLERANCE)
        {
            List<XmlNode> similar = new List<XmlNode>();

            XmlNode dummy = newReb["B2aBar"];
            XmlNode dummy_geometry = dummy["B2aGeometry"];

            string dummy_dim = emptyNodehandle(dummy, "Dim");
            string dummy_type = dummy["Type"].InnerText;

            foreach (XmlNode rebar in rebars)
            {
                bool found = true;

                XmlNode existing = rebar["B2aBar"];
                if (existing == null) continue;

                string dim = emptyNodehandle(existing, "Dim");
                if (dummy_dim != "???" && dim != "???" && dummy_dim != dim) continue;

                XmlNode existing_geometry = existing["B2aGeometry"];

                if (existing_geometry == null)
                {
                    similar.Add(rebar);
                    continue;
                }

                if (dummy_type == "B")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;

                    if (found == false)
                    {
                        found = true;
                        if (new_a != "???" && old_b != "???" && new_a != old_b) found = false;
                        if (new_b != "???" && old_a != "???" && new_b != old_a) found = false;
                    }

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "C")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;

                    if (found == false)
                    {
                        found = true;
                        if (new_a != "???" && old_c != "???" && new_a != old_c) found = false;
                        if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                        if (new_c != "???" && old_a != "???" && new_c != old_a) found = false;
                    }

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "D")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found == false)
                    {
                        found = true;
                        if (new_a != "???" && old_b != "???" && new_a != old_b) found = false;
                        if (new_b != "???" && old_a != "???" && new_b != old_a) found = false;
                        if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    }

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "E")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_v = emptyNodehandle(existing_geometry, "V");
                    string old_u = emptyNodehandle(existing_geometry, "U");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_v = emptyNodehandle(dummy_geometry, "V");
                    string new_u = emptyNodehandle(dummy_geometry, "U");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    if (new_u != "???" && old_u != "???" && new_u != old_u) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "EX")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_y = emptyNodehandle(existing_geometry, "Y");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "F")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found == false)
                    {
                        found = true;
                        if (new_a != "???" && old_b != "???" && new_a != old_b) found = false;
                        if (new_b != "???" && old_a != "???" && new_b != old_a) found = false;
                        if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    }

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "G")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_v = emptyNodehandle(existing_geometry, "V");
                    string old_s = emptyNodehandle(existing_geometry, "S");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_v = emptyNodehandle(dummy_geometry, "V");
                    string new_s = emptyNodehandle(dummy_geometry, "S");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    if (new_s != "???" && old_s != "???" && new_s != old_s) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "H")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_v = emptyNodehandle(existing_geometry, "V");
                    string old_s = emptyNodehandle(existing_geometry, "S");
                    string old_u = emptyNodehandle(existing_geometry, "U");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_v = emptyNodehandle(dummy_geometry, "V");
                    string new_s = emptyNodehandle(dummy_geometry, "S");
                    string new_u = emptyNodehandle(dummy_geometry, "U");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    if (new_s != "???" && old_s != "???" && new_s != old_s) found = false;
                    if (new_u != "???" && old_u != "???" && new_u != old_u) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "J")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_y = emptyNodehandle(existing_geometry, "Y");
                    string old_v = emptyNodehandle(existing_geometry, "V");
                    string old_s = emptyNodehandle(existing_geometry, "S");
                    string old_t = emptyNodehandle(existing_geometry, "T");
                    string old_u = emptyNodehandle(existing_geometry, "U");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");
                    string new_v = emptyNodehandle(dummy_geometry, "V");
                    string new_s = emptyNodehandle(dummy_geometry, "S");
                    string new_t = emptyNodehandle(dummy_geometry, "T");
                    string new_u = emptyNodehandle(dummy_geometry, "U");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    if (new_s != "???" && old_s != "???" && new_s != old_s) found = false;
                    if (new_t != "???" && old_t != "???" && new_t != old_t) found = false;
                    if (new_u != "???" && old_u != "???" && new_u != old_u) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "K")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "L")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_f = emptyNodehandle(existing_geometry, "F");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_f = emptyNodehandle(dummy_geometry, "F");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_f != "???" && old_f != "???" && new_f != old_f) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "LX")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_v = emptyNodehandle(existing_geometry, "V");
                    string old_s = emptyNodehandle(existing_geometry, "S");
                    string old_u = emptyNodehandle(existing_geometry, "U");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_v = emptyNodehandle(dummy_geometry, "V");
                    string new_s = emptyNodehandle(dummy_geometry, "S");
                    string new_u = emptyNodehandle(dummy_geometry, "U");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    if (new_s != "???" && old_s != "???" && new_s != old_s) found = false;
                    if (new_u != "???" && old_u != "???" && new_u != old_u) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "M")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_f = emptyNodehandle(existing_geometry, "F");
                    string old_g = emptyNodehandle(existing_geometry, "G");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_y = emptyNodehandle(existing_geometry, "Y");
                    string old_v = emptyNodehandle(existing_geometry, "V");
                    string old_s = emptyNodehandle(existing_geometry, "S");
                    string old_t = emptyNodehandle(existing_geometry, "T");
                    string old_u = emptyNodehandle(existing_geometry, "U");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_f = emptyNodehandle(dummy_geometry, "F");
                    string new_g = emptyNodehandle(dummy_geometry, "G");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");
                    string new_v = emptyNodehandle(dummy_geometry, "V");
                    string new_s = emptyNodehandle(dummy_geometry, "S");
                    string new_t = emptyNodehandle(dummy_geometry, "T");
                    string new_u = emptyNodehandle(dummy_geometry, "U");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_f != "???" && old_f != "???" && new_f != old_f) found = false;
                    if (new_g != "???" && old_g != "???" && new_g != old_g) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;
                    if (new_s != "???" && old_s != "???" && new_s != old_s) found = false;
                    if (new_t != "???" && old_t != "???" && new_t != old_t) found = false;
                    if (new_u != "???" && old_u != "???" && new_u != old_u) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "N")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;

                    if (found == false)
                    {
                        found = true;
                        if (new_a != "???" && old_b != "???" && new_a != old_b) found = false;
                        if (new_b != "???" && old_a != "???" && new_b != old_a) found = false;
                    }

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "NX")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "O")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_y = emptyNodehandle(existing_geometry, "Y");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "Q")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_x = emptyNodehandle(existing_geometry, "X");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_x = emptyNodehandle(dummy_geometry, "X");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "R")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_y = emptyNodehandle(existing_geometry, "Y");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "S")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_y = emptyNodehandle(existing_geometry, "Y");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "SH")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_y = emptyNodehandle(existing_geometry, "Y");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "SX")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_y = emptyNodehandle(existing_geometry, "Y");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "T")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "U")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_y = emptyNodehandle(existing_geometry, "Y");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "V")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_y = emptyNodehandle(existing_geometry, "Y");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_y = emptyNodehandle(dummy_geometry, "Y");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_y != "???" && old_y != "???" && new_y != old_y) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "W")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_x = emptyNodehandle(existing_geometry, "X");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_x = emptyNodehandle(dummy_geometry, "X");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_x != "???" && old_x != "???" && new_x != old_x) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "X")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "XX")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_e = emptyNodehandle(existing_geometry, "E");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_e = emptyNodehandle(dummy_geometry, "E");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_e != "???" && old_e != "???" && new_e != old_e) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
                else if (dummy_type == "Z")
                {
                    string old_a = emptyNodehandle(existing_geometry, "A");
                    string old_b = emptyNodehandle(existing_geometry, "B");
                    string old_c = emptyNodehandle(existing_geometry, "C");
                    string old_d = emptyNodehandle(existing_geometry, "D");
                    string old_v = emptyNodehandle(existing_geometry, "V");

                    string new_a = emptyNodehandle(dummy_geometry, "A");
                    string new_b = emptyNodehandle(dummy_geometry, "B");
                    string new_c = emptyNodehandle(dummy_geometry, "C");
                    string new_d = emptyNodehandle(dummy_geometry, "D");
                    string new_v = emptyNodehandle(dummy_geometry, "V");

                    if (new_a != "???" && old_a != "???" && new_a != old_a) found = false;
                    if (new_b != "???" && old_b != "???" && new_b != old_b) found = false;
                    if (new_c != "???" && old_c != "???" && new_c != old_c) found = false;
                    if (new_d != "???" && old_d != "???" && new_d != old_d) found = false;
                    if (new_v != "???" && old_v != "???" && new_v != old_v) found = false;

                    if (found) similar.Add(rebar);
                }
            }

            return similar;
        }


        //NOT THIS!
        public static XmlNode compare(XmlNode newReb, XmlNode rebar)
        {
            XmlNode old_bar = rebar["B2aBar"];
            XmlNode new_bar = newReb["B2aBar"];
       
            if (old_bar == null) return null;
            if (new_bar == null) return null;

            string new_type = new_bar["Type"].InnerText;

            XmlNode old_geometry = old_bar["B2aGeometry"];
            XmlNode new_geometry = new_bar["B2aGeometry"];

            if (new_type == "A")
            {
                return null;
            }
            else
            {
                if (old_geometry == null) return null;
                if (new_geometry == null) return null;

                string old_dim = emptyNodehandle(old_bar, "Dim");
                string new_dim = emptyNodehandle(new_bar, "Dim");

                if (old_dim == "???") return null;
                if (new_dim == "???") return null;
                if (old_dim != new_dim) return null;

                if (new_type == "B")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_r = emptyNodehandle(new_geometry, "R");


                    if (old_a == "???" || old_b == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "C")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_c == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_c == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_c == new_c &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "D")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_v == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_v == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_v == new_v &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "E")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_u = emptyNodehandle(old_geometry, "U");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_u = emptyNodehandle(new_geometry, "U");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_c == "???" || old_v == "???" || old_u == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_c == "???" || new_v == "???" || new_u == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_c == new_c &&
                        old_v == new_v &&
                        old_u == new_u &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "EX")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_y = emptyNodehandle(old_geometry, "Y");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_y = emptyNodehandle(new_geometry, "Y");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_c == "???" || old_y == "???" || old_v == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_c == "???" || new_y == "???" || new_v == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_c == new_c &&
                        old_y == new_y &&
                        old_v == new_v &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "F")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_v == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_v == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_v == new_v &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "G")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_x = emptyNodehandle(old_geometry, "X");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_s = emptyNodehandle(old_geometry, "S");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_x = emptyNodehandle(new_geometry, "X");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_s = emptyNodehandle(new_geometry, "S");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_c == "???" || old_x == "???" || old_v == "???" || old_s == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_c == "???" || new_x == "???" || new_v == "???" || new_s == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_c == new_c &&
                        old_x == new_x &&
                        old_v == new_v &&
                        old_s == new_s &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "H")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_e = emptyNodehandle(old_geometry, "E");
                    string old_x = emptyNodehandle(old_geometry, "X");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_s = emptyNodehandle(old_geometry, "S");
                    string old_u = emptyNodehandle(old_geometry, "U");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_e = emptyNodehandle(new_geometry, "E");
                    string new_x = emptyNodehandle(new_geometry, "X");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_s = emptyNodehandle(new_geometry, "S");
                    string new_u = emptyNodehandle(new_geometry, "U");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_d == "???" || old_e == "???" || old_x == "???" || old_v == "???" || old_s == "???" || old_u == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_d == "???" || new_e == "???" || new_x == "???" || new_v == "???" || new_s == "???" || new_u == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_d == new_d &&
                        old_e == new_e &&
                        old_x == new_x &&
                        old_v == new_v &&
                        old_s == new_s &&
                        old_u == new_u &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "J")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_e = emptyNodehandle(old_geometry, "E");
                    string old_x = emptyNodehandle(old_geometry, "X");
                    string old_y = emptyNodehandle(old_geometry, "Y");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_s = emptyNodehandle(old_geometry, "S");
                    string old_t = emptyNodehandle(old_geometry, "T");
                    string old_u = emptyNodehandle(old_geometry, "U");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_e = emptyNodehandle(new_geometry, "E");
                    string new_x = emptyNodehandle(new_geometry, "X");
                    string new_y = emptyNodehandle(new_geometry, "Y");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_s = emptyNodehandle(new_geometry, "S");
                    string new_t = emptyNodehandle(new_geometry, "T");
                    string new_u = emptyNodehandle(new_geometry, "U");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_c == "???" || old_e == "???" || old_x == "???" || old_y == "???" || old_v == "???" || old_s == "???" || old_t == "???" || old_u == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_c == "???" || new_e == "???" || new_x == "???" || new_y == "???" || new_v == "???" || new_s == "???" || new_t == "???" || new_u == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_c == new_c &&
                        old_e == new_e &&
                        old_x == new_x &&
                        old_y == new_y &&
                        old_v == new_v &&
                        old_s == new_s &&
                        old_t == new_t &&
                        old_u == new_u &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "K")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_c == "???" || old_d == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_c == "???" || new_d == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_c == new_c &&
                        old_d == new_d &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "L")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_e = emptyNodehandle(old_geometry, "E");
                    string old_f = emptyNodehandle(old_geometry, "F");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_e = emptyNodehandle(new_geometry, "E");
                    string new_f = emptyNodehandle(new_geometry, "F");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_c == "???" || old_d == "???" || old_e == "???" || old_f == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_c == "???" || new_d == "???" || new_e == "???" || new_f == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_c == new_c &&
                        old_d == new_d &&
                        old_e == new_e &&
                        old_f == new_f &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "LX")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_e = emptyNodehandle(old_geometry, "E");
                    string old_x = emptyNodehandle(old_geometry, "X");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_s = emptyNodehandle(old_geometry, "S");
                    string old_u = emptyNodehandle(old_geometry, "U");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_e = emptyNodehandle(new_geometry, "E");
                    string new_x = emptyNodehandle(new_geometry, "X");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_s = emptyNodehandle(new_geometry, "S");
                    string new_u = emptyNodehandle(new_geometry, "U");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_d == "???" || old_e == "???" || old_x == "???" || old_v == "???" || old_s == "???" || old_u == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_d == "???" || new_e == "???" || new_x == "???" || new_v == "???" || new_s == "???" || new_u == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_d == new_d &&
                        old_e == new_e &&
                        old_x == new_x &&
                        old_v == new_v &&
                        old_s == new_s &&
                        old_u == new_u &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "M")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_f = emptyNodehandle(old_geometry, "F");
                    string old_g = emptyNodehandle(old_geometry, "G");
                    string old_x = emptyNodehandle(old_geometry, "X");
                    string old_y = emptyNodehandle(old_geometry, "Y");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_s = emptyNodehandle(old_geometry, "S");
                    string old_t = emptyNodehandle(old_geometry, "T");
                    string old_u = emptyNodehandle(old_geometry, "U");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_f = emptyNodehandle(new_geometry, "F");
                    string new_g = emptyNodehandle(new_geometry, "G");
                    string new_x = emptyNodehandle(new_geometry, "X");
                    string new_y = emptyNodehandle(new_geometry, "Y");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_s = emptyNodehandle(new_geometry, "S");
                    string new_t = emptyNodehandle(new_geometry, "T");
                    string new_u = emptyNodehandle(new_geometry, "U");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_d == "???" || old_f == "???" || old_g == "???" || old_x == "???" || old_y == "???" || old_v == "???" || old_s == "???" || old_t == "???" || old_u == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_d == "???" || new_f == "???" || new_g == "???" || new_x == "???" || new_y == "???" || new_v == "???" || new_s == "???" || new_t == "???" || new_u == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_d == new_d &&
                        old_f == new_f &&
                        old_g == new_g &&
                        old_x == new_x &&
                        old_y == new_y &&
                        old_v == new_v &&
                        old_s == new_s &&
                        old_t == new_t &&
                        old_u == new_u &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "N")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_r = emptyNodehandle(old_geometry, "R");
                    string old_e1 = emptyNodehandle(old_geometry, "End1");
                    string old_e2 = emptyNodehandle(old_geometry, "End2");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_r = emptyNodehandle(new_geometry, "R");
                    string new_e1 = emptyNodehandle(new_geometry, "End1");
                    string new_e2 = emptyNodehandle(new_geometry, "End2");

                    if (old_a == "???" || old_b == "???" || old_r == "???" || old_e1 == "???" || old_e2 == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_r == "???" || new_e1 == "???" || new_e2 == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_r == new_r &&
                        old_e1 == new_e1 &&
                        old_e2 == new_e2) return rebar;
                }
                else if (new_type == "NX")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_r = emptyNodehandle(old_geometry, "R");
                    string old_e1 = emptyNodehandle(old_geometry, "End1");
                    string old_e2 = emptyNodehandle(old_geometry, "End2");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_r = emptyNodehandle(new_geometry, "R");
                    string new_e1 = emptyNodehandle(new_geometry, "End1");
                    string new_e2 = emptyNodehandle(new_geometry, "End2");

                    if (old_a == "???" || old_d == "???" || old_v == "???" || old_r == "???" || old_e1 == "???" || old_e2 == "???") return null;
                    if (new_a == "???" || new_d == "???" || new_v == "???" || new_r == "???" || new_e1 == "???" || new_e2 == "???") return null;

                    if (old_a == new_a &&
                        old_d == new_d &&
                        old_v == new_v &&
                        old_r == new_r &&
                        old_e1 == new_e1 &&
                        old_e2 == new_e2) return rebar;
                }
                else if (new_type == "O")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_x = emptyNodehandle(old_geometry, "X");
                    string old_y = emptyNodehandle(old_geometry, "Y");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_x = emptyNodehandle(new_geometry, "X");
                    string new_y = emptyNodehandle(new_geometry, "Y");

                    if (old_a == "???" || old_x == "???" || old_y == "???") return null;
                    if (new_a == "???" || new_x == "???" || new_y == "???") return null;

                    if (old_a == new_a &&
                        old_x == new_x &&
                        old_y == new_y) return rebar;
                }
                else if (new_type == "Q")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_x = emptyNodehandle(old_geometry, "X");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_x = emptyNodehandle(new_geometry, "X");

                    if (old_a == "???" || old_x == "???") return null;
                    if (new_a == "???" || new_x == "???") return null;

                    if (old_a == new_a &&
                        old_x == new_x) return rebar;
                }
                else if (new_type == "R")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_y = emptyNodehandle(old_geometry, "Y");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_y = emptyNodehandle(new_geometry, "Y");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_c == "???" || old_d == "???" || old_y == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_c == "???" || new_d == "???" || new_y == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_c == new_c &&
                        old_d == new_d &&
                        old_y == new_y &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "S")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_y = emptyNodehandle(old_geometry, "Y");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_y = emptyNodehandle(new_geometry, "Y");

                    if (old_a == "???" || old_b == "???" || old_y == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_y == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_y == new_y) return rebar;
                }
                else if (new_type == "SH")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_y = emptyNodehandle(old_geometry, "Y");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_y = emptyNodehandle(new_geometry, "Y");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_c == "???" || old_d == "???" || old_y == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_c == "???" || new_d == "???" || new_y == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_c == new_c &&
                        old_d == new_d &&
                        old_y == new_y &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "SX")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_y = emptyNodehandle(old_geometry, "Y");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_y = emptyNodehandle(new_geometry, "Y");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_c == "???" || old_d == "???" || old_y == "???" || old_v == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_c == "???" || new_d == "???" || new_y == "???" || new_v == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_c == new_c &&
                        old_d == new_d &&
                        old_y == new_y &&
                        old_v == new_v &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "T")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_e = emptyNodehandle(old_geometry, "E");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_e = emptyNodehandle(new_geometry, "E");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_c == "???" || old_d == "???" || old_e == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_c == "???" || new_d == "???" || new_e == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_c == new_c &&
                        old_d == new_d &&
                        old_e == new_e &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "U")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_x = emptyNodehandle(old_geometry, "X");
                    string old_y = emptyNodehandle(old_geometry, "Y");
                    string old_r = emptyNodehandle(old_geometry, "R");
                    string old_e1 = emptyNodehandle(old_geometry, "End1");
                    string old_e2 = emptyNodehandle(old_geometry, "End2");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_x = emptyNodehandle(new_geometry, "X");
                    string new_y = emptyNodehandle(new_geometry, "Y");
                    string new_r = emptyNodehandle(new_geometry, "R");
                    string new_e1 = emptyNodehandle(new_geometry, "End1");
                    string new_e2 = emptyNodehandle(new_geometry, "End2");

                    if (old_a == "???" || old_c == "???" || old_x == "???" || old_y == "???" || old_r == "???" || old_e1 == "???" || old_e2 == "???") return null;
                    if (new_a == "???" || new_c == "???" || new_x == "???" || new_y == "???" || new_r == "???" || new_e1 == "???" || new_e2 == "???") return null;

                    if (old_a == new_a &&
                        old_c == new_c &&
                        old_x == new_x &&
                        old_y == new_y &&
                        old_r == new_r &&
                        old_e1 == new_e1 &&
                        old_e2 == new_e2) return rebar;
                }
                else if (new_type == "V")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_x = emptyNodehandle(old_geometry, "X");
                    string old_y = emptyNodehandle(old_geometry, "Y");
                    string old_r = emptyNodehandle(old_geometry, "R");
                    string old_e1 = emptyNodehandle(old_geometry, "End1");
                    string old_e2 = emptyNodehandle(old_geometry, "End2");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_x = emptyNodehandle(new_geometry, "X");
                    string new_y = emptyNodehandle(new_geometry, "Y");
                    string new_r = emptyNodehandle(new_geometry, "R");
                    string new_e1 = emptyNodehandle(new_geometry, "End1");
                    string new_e2 = emptyNodehandle(new_geometry, "End2");

                    if (old_a == "???" || old_x == "???" || old_y == "???" || old_r == "???" || old_e1 == "???" || old_e2 == "???") return null;
                    if (new_a == "???" || new_x == "???" || new_y == "???" || new_r == "???" || new_e1 == "???" || new_e2 == "???") return null;

                    if (old_a == new_a &&
                        old_x == new_x &&
                        old_y == new_y &&
                        old_r == new_r &&
                        old_e1 == new_e1 &&
                        old_e2 == new_e2) return rebar;
                }
                else if (new_type == "W")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_e = emptyNodehandle(old_geometry, "E");
                    string old_x = emptyNodehandle(old_geometry, "X");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_e = emptyNodehandle(new_geometry, "E");
                    string new_x = emptyNodehandle(new_geometry, "X");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_d == "???" || old_e == "???" || old_x == "???" || old_v == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_d == "???" || new_e == "???" || new_x == "???" || new_v == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_d == new_d &&
                        old_e == new_e &&
                        old_x == new_x &&
                        old_v == new_v &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "X")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_e = emptyNodehandle(old_geometry, "E");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_e = emptyNodehandle(new_geometry, "E");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_c == "???" || old_d == "???" || old_e == "???" || old_v == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_c == "???" || new_d == "???" || new_e == "???" || new_v == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_c == new_c &&
                        old_d == new_d &&
                        old_e == new_e &&
                        old_v == new_v &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "XX")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_e = emptyNodehandle(old_geometry, "E");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_e = emptyNodehandle(new_geometry, "E");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_c == "???" || old_d == "???" || old_e == "???" || old_v == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_c == "???" || new_d == "???" || new_e == "???" || new_v == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_c == new_c &&
                        old_d == new_d &&
                        old_e == new_e &&
                        old_v == new_v &&
                        old_r == new_r) return rebar;
                }
                else if (new_type == "Z")
                {
                    string old_a = emptyNodehandle(old_geometry, "A");
                    string old_b = emptyNodehandle(old_geometry, "B");
                    string old_c = emptyNodehandle(old_geometry, "C");
                    string old_d = emptyNodehandle(old_geometry, "D");
                    string old_v = emptyNodehandle(old_geometry, "V");
                    string old_r = emptyNodehandle(old_geometry, "R");

                    string new_a = emptyNodehandle(new_geometry, "A");
                    string new_b = emptyNodehandle(new_geometry, "B");
                    string new_c = emptyNodehandle(new_geometry, "C");
                    string new_d = emptyNodehandle(new_geometry, "D");
                    string new_v = emptyNodehandle(new_geometry, "V");
                    string new_r = emptyNodehandle(new_geometry, "R");

                    if (old_a == "???" || old_b == "???" || old_c == "???" || old_d == "???" || old_v == "???" || old_r == "???") return null;
                    if (new_a == "???" || new_b == "???" || new_c == "???" || new_d == "???" || new_v == "???" || new_r == "???") return null;

                    if (old_a == new_a &&
                        old_b == new_b &&
                        old_c == new_c &&
                        old_d == new_d &&
                        old_v == new_v &&
                        old_r == new_r) return rebar;
                }
            }

            return null;
        }


        public static List<XmlNode> filter(List<XmlNode> rows, string userFilter)
        {
            List<XmlNode> filtered = new List<XmlNode>();
            if (userFilter == "ALL")
            {
                filtered = rows;
            }
            else if (userFilter == "SPEC")
            {
                foreach (XmlNode row in rows)
                {
                    XmlNode temp_reb = row["B2aBar"];
                    if (temp_reb == null)
                    {
                        filtered.Add(row);
                        continue;
                    }

                    XmlNode temp_type = temp_reb["Type"];

                    if (temp_type == null)
                    {
                        filtered.Add(row);
                        continue;
                    }

                    if (temp_type.InnerText == "A")
                    {
                        continue;
                    }

                    filtered.Add(row);
                }
            }
            else if (userFilter == "LAST")
            {
                foreach (XmlNode row in rows)
                {
                    XmlNode temp_reb = row["B2aBar"];
                    if (temp_reb == null)
                    {
                        filtered.Add(row);
                        continue;
                    }

                    XmlNode temp_type = temp_reb["Type"];

                    if (temp_type == null)
                    {
                        filtered.Add(row);
                        continue;
                    }

                    if (temp_type.InnerText == "A")
                    {
                        continue;
                    }

                    filtered.Add(row);
                }

                XmlNode last = filtered[filtered.Count - 1];
                filtered = new List<XmlNode>();
                filtered.Add(last);
            }
            else
            {
                foreach (XmlNode row in rows)
                {
                    XmlNode temp_reb = row["B2aBar"];
                    if (temp_reb == null)
                    {
                        continue;
                    }

                    XmlNode temp_type = temp_reb["Type"];

                    if (temp_type == null)
                    {
                        continue;
                    }

                    if (temp_type.InnerText == userFilter)
                    {
                        filtered.Add(row);
                    }
                }
            }

            return filtered;
        }


        private static string prompt(string suurus, _Ed.Editor ed)
        {
            string res = "";

            _Ed.PromptStringOptions promptOptions = new _Ed.PromptStringOptions("");
            promptOptions.Message = "\n" + suurus;
            promptOptions.DefaultValue = "";
            _Ed.PromptResult promptResult = ed.GetString(promptOptions);

            if (promptResult.Status == _Ed.PromptStatus.OK)
            {
                res = promptResult.StringResult;
            }

            return res;
        }


        public static XmlNode newPageHandle(List<XmlNode> pages, XmlDocument xmlDoc)
        {
            XmlNode row = xmlDoc.CreateElement("B2aPage");
            XmlAttribute attribute = xmlDoc.CreateAttribute("PageLabel");
            attribute.Value = "A-" + (pages.Count + 1).ToString("D2");
            row.Attributes.Append(attribute);

            XmlNode head = xmlDoc.CreateElement("B2aPageHead");

            XmlNode c10 = xmlDoc.CreateElement("ConcreteFctk10");
            XmlNode cf10 = xmlDoc.CreateElement("ConcreteCoverFactor10");

            head.AppendChild(c10);
            head.AppendChild(cf10);

            row.AppendChild(head);

            return row;
        }


        public static string emptyNodehandle(XmlNode rebar, string search)
        {
            XmlNode result = rebar[search];
            if (result == null)
            {
                return "???";
            }
            else
            {
                string innerText = result.InnerText;
                if (innerText.Length > 0)
                {
                    return result.InnerText;
                }
                else
                {
                    return "???";
                }

            }
        }

        public static List<XmlNode> getAllRebar(XmlDocument file)
        {
            List<XmlNode> rebars = new List<XmlNode>();

            foreach (XmlNode page in file.DocumentElement)
            {
                if (page.Name != "B2aPage") continue;

                foreach (XmlNode row in page.ChildNodes)
                {
                    if (row.Name != "B2aPageRow") continue;

                    rebars.Add(row);
                }
            }

            return rebars;
        }


        public static List<XmlNode> getAllPages(XmlDocument file)
        {
            List<XmlNode> pages = new List<XmlNode>();

            foreach (XmlNode page in file.DocumentElement)
            {
                if (page.Name != "B2aPage") continue;

                pages.Add(page);
            }

            return pages;
        }


        public static XmlDocument removeEmptyNodes(XmlDocument xd) // DONT KNOW THIS MAGIC
        {
            XmlNodeList emptyElements = xd.SelectNodes(@"//*[not(node())]");
            for (int i = emptyElements.Count - 1; i > -1; i--)
            {
                XmlNode nodeToBeRemoved = emptyElements[i];
                nodeToBeRemoved.ParentNode.RemoveChild(nodeToBeRemoved);
            }

            return xd;
        }


        private static void removeHandle(XmlNode parent, XmlNode child)
        {
            string content = child.InnerText;
            content = content.Replace(" ", "");
            if (content.Length == 0)
            {
                parent.RemoveChild(child);
            }
        }
        
    }
}