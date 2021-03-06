﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace QuizApp_1._0
{
    public class XmlMethods
    {
        
        public static XDocument LoadXDocumnet(string filename)
        {
            XDocument doc;
            try
            {
                doc = XDocument.Load(filename);
               // creatXmlDocument(filename);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("The file " + filename + " not found create a new One");

                creatXmlDocument(filename);
            }
            catch (XmlException ex)
            {

                MessageBox.Show("Error! \n File Corrupted \n Make New One as Same Name");

                creatXmlDocument(filename);
            }
            return XDocument.Load(filename);
        }

        public static void InsertNewField(string fileName, string ID, string Question,
            string Op1,string Op2,string Op3,string Op4, string Ans1, string Ans2, string Ans3, string Ans4)
        {
            XDocument contact = XDocument.Load(fileName);

            XElement newElement = new XElement("Question",
                        new XAttribute("ID", ID),
                                    new XElement("Qs", Question),
                                    new XElement("Op1", Op1),
                                    new XElement("Op2", Op2),
                                    new XElement("Op3", Op3),
                                    new XElement("Op4", Op4),
                                    new XElement("Ans1", Ans1),
                                    new XElement("Ans2", Ans2),
                                    new XElement("Ans3", Ans3),
                                    new XElement("Ans4", Ans4)
                                    
                                    
                );

            contact.Descendants("Quiz").First().Add(newElement);
            

            contact.Save(fileName);
        }
        //now search using query in xml
        public static string  getQuention(string fileName,string element,string QID)
        {
            
            XDocument inventoryDoc = XDocument.Load(fileName);
          
            var makeInfo = from contact in inventoryDoc.Descendants("Question")
                           where (string)contact.FirstAttribute == QID

                           select contact.Element(element).Value;  //element="Qs"
           
            string data = string.Empty;
            
                data = string.Format("{0}",makeInfo.ToString());
            foreach (var item in makeInfo.Distinct())
            {
                data = string.Format("{0}\n", item);
            }
            
            return data;


        }
       
        

        public static void DeleteField(String fileName, String ID)
        {

            //april 17, 2018 method implemrnted
            XDocument inventorydoc = XDocument.Load(fileName);
            var namestodelete = from contact in inventorydoc.Descendants("Question")
                                where (string)contact.FirstAttribute == ID
                                select contact; //only use implict type
            namestodelete.Remove();
            inventorydoc.Save(fileName);


        }

        public static List<string> getIDs(string fileName)
        {

           
            XDocument inventoryDoc = XDocument.Load(fileName);


            
            var ID = from contact in inventoryDoc.Descendants("Question")
                        select contact.FirstAttribute.Value; 

            
            List<string> Ids = new List<string>(100);

            
            foreach (var item in ID.Distinct()) 
            {
                Ids.Add(item.ToString());
            }
           
            return Ids;

        }


        /* create documnet if old one gets deletd */
        public static XDocument creatXmlDocument(string fileName)
        {
            XDocument xDocument = new XDocument
                (
                new XElement("Quiz",
                new XElement("Question",
                        new XAttribute("ID", "1"),
                                    new XElement("Qs", "Q1"),
                                    new XElement("Op1", "0"),
                                    new XElement("Op2", "0"),
                                    new XElement("Op3", "0"),
                                    new XElement("Op4", "0"),
                                    new XElement("Ans1", "0"),
                                    new XElement("Ans2", "0"),
                                    new XElement("Ans3", "0"),
                                    new XElement("Ans4", "0")                                    
                )
                )
                );
            xDocument.Save(fileName);
            return xDocument;
        }

        public static int getNumberOfElement(string filename)
        {
            
            XDocument doc = XDocument.Load(filename);

            IEnumerable<string> names = from Contactlist in doc.Descendants("Question").Distinct()
                                        select Contactlist.FirstAttribute.
                                        Value;

            List<String> DistinctNames = new List<string>();
            foreach (var n in names.Distinct())
            {
                DistinctNames.Add(n);
            }
            int number = DistinctNames.Count;

            return number;
        }
        
    }
}
