﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DR = System.Drawing;

//Autocad
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;

////Bricsys
//using Teigha.Runtime;
//using Teigha.DatabaseServices;
//using Teigha.Geometry;
//using Bricscad.ApplicationServices;
//using Bricscad.Runtime;
//using Bricscad.EditorInput;

namespace commands
{
    class OVERRIDE_command
    {
        Document doc;
        Database db;
        Editor ed;

        Transaction trans;

        Dictionary<Dimension, BlockTableRecord> dims;


        public OVERRIDE_command()
        {
            doc = Application.DocumentManager.MdiActiveDocument;
            db = doc.Database;
            ed = doc.Editor;

            trans = db.TransactionManager.StartTransaction();

            dims = new Dictionary<Dimension, BlockTableRecord>();
        }


        internal void run()
        {
            writeCadMessage("START");

            getAllDims();
            setColorToDims();

            writeCadMessage("END");
        }


        private void writeCadMessage(string errorMessage)
        {
            ed.WriteMessage("\n" + errorMessage);
        }


        private void setColorToDims()
        {
            List<Dimension> overrides = new List<Dimension>();

            foreach (Dimension dim in dims.Keys)
            {
                if (dim.DimensionText != "")
                {
                    string alfa = dim.DimensionText;
                    alfa = alfa.Replace(" ", "");
                    
                    if (alfa != "")
                    {
                        overrides.Add(dim);
                    }
                    
                }
            }

            foreach (Dimension dim in overrides)
            {
                createCircle(2000, 1, dim.TextPosition, dims[dim]);
                createCircle(200, 1, dim.TextPosition, dims[dim]);
            }

            writeCadMessage("Override count: " + overrides.Count.ToString());
        }
        

        private void getAllDims()
        {
            BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForWrite) as BlockTable;
            foreach (ObjectId btrId in bt)
            {
                BlockTableRecord btr = trans.GetObject(btrId, OpenMode.ForWrite) as BlockTableRecord;
                if (!(btr.IsFromExternalReference))
                {
                    foreach (ObjectId bid in btr)
                    {
                        Entity currentEntity = trans.GetObject(bid, OpenMode.ForWrite, false) as Entity;

                        if (currentEntity == null)
                        {
                            continue;
                        }

                        if (currentEntity is Dimension)
                        {
                            Dimension dim = currentEntity as Dimension;
                            dims[dim] = btr;
                        }
                    }
                }
            }
        }


        private void createCircle(double radius, int index, Point3d ip, BlockTableRecord btr)
        {
            using (Circle circle = new Circle())
            {
                circle.Center = ip;
                circle.Radius = radius;
                circle.ColorIndex = index;
                btr.AppendEntity(circle);
                trans.AddNewlyCreatedDBObject(circle, true);
            }
        }


        internal void close()
        {
            trans.Commit();
            trans.Dispose();

            ed.Regen();
        }
    }
}
