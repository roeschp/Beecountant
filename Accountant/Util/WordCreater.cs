using Accountant.Objects;
using Microsoft.Office.Interop.Word;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;


namespace Accountant.Util
{
    public static class WordCreater
    {
        private const string TemplateFile = "Template.docx";
        private const string TemplateFolder = "Template";
        private const string InvoiceFolder = "Invoices";
        private const string DocumentFolder = "Documents";
        private static object TemplatePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), TemplateFolder, TemplateFile);

        private static object mMissing = Missing.Value;
        private static Word.Application? aWord ;
        private static Word.Document? document;

        public static void CreateWord(CustomerObject tCustomer ,OrderObject tOrderObject)
        {
            try
            {
                aWord = new Word.Application();
                aWord.Visible = false;
                document = aWord.Documents.OpenNoRepairDialog(TemplatePath);

                document.Activate();

                SearchReplace("cNr", tOrderObject.Id);
                SearchReplace("cDate", $"{DateTime.Now.ToString("dd/MM/yyyy").Replace('-', '/')}");

                if (string.IsNullOrEmpty(tCustomer.CompanyName) == false)
                    SearchReplace("cCompany", tCustomer.CompanyName);
                if (string.IsNullOrEmpty(tCustomer.FirstName) == false)
                    SearchReplace("cFirstName", tCustomer.FirstName);
                if (string.IsNullOrEmpty(tCustomer.LastName) == false)
                    SearchReplace("cLastName", tCustomer.LastName);
                if (string.IsNullOrEmpty(tCustomer.Street) == false)
                    SearchReplace("cStreet", tCustomer.Street);
                if (string.IsNullOrEmpty(tCustomer.HouseNumber) == false)
                    SearchReplace("cHouseNumber", tCustomer.HouseNumber);
                if (string.IsNullOrEmpty(tCustomer.City) == false)
                    SearchReplace("cCity", tCustomer.City);
                if (string.IsNullOrEmpty(tCustomer.PostalCode) == false)
                    SearchReplace("cPostalCode", tCustomer.PostalCode);

                Word.Table aTable = document.Tables[1];

                int aRowIndex = 2;

                for (int aIndex = 0; aIndex < tOrderObject.Products.Count; aIndex++)
                {
                    int aCellIndex = 1;

                    aTable.Cell(aRowIndex, aCellIndex).Range.Text = tOrderObject.Products[aIndex].Count.ToString();
                    aCellIndex++;
                    aTable.Cell(aRowIndex, aCellIndex).Range.Text = tOrderObject.Products[aIndex].Name.ToString();
                    aCellIndex++;
                    aTable.Cell(aRowIndex, aCellIndex).Range.Text = $"{tOrderObject.Products[aIndex].SinglePrice}€";
                    aCellIndex++;
                    aTable.Cell(aRowIndex, aCellIndex).Range.Text = $"{tOrderObject.Products[aIndex].Weight}{tOrderObject.Products[aIndex].Unit}";
                    aCellIndex++;
                    aTable.Cell(aRowIndex, aCellIndex).Range.Text = $"{tOrderObject.Products[aIndex].SubTotal}€";
                    aRowIndex++;
                    aTable.Rows.Add(aTable.Rows[aRowIndex]);

                }

                double aTotal = Math.Round(tOrderObject.Price * Util.TaxesFactor, 2);
                double aTaxes = Math.Round(aTotal - tOrderObject.Price, 2);

                SearchReplace("cNoTaxes", $"{tOrderObject.Price}€");
                SearchReplace("cTaxes", $"{aTaxes}€");
                SearchReplace("cTotal", $"{aTotal}€");
                
                document.SaveAs2(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), InvoiceFolder, DocumentFolder, tOrderObject.Id + ".docx"));
                document.SaveAs2(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), InvoiceFolder, tOrderObject.Id + ".pdf"), WdSaveFormat.wdFormatPDF);
                aWord.Quit();
                
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo()
                {
                    CreateNoWindow = true,
                    Verb = "print",
                    FileName = "explorer",
                    Arguments = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), InvoiceFolder, tOrderObject.Id + ".pdf" )// put the path of the pdf file you want to print
                };
                p.Start();

            }
            catch
            {
                MessageBox.Show("Error - Failed to create Word document", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private static void SearchReplace(string tFind, string tReplace)
        {
            Word.Find findObject = document.Application.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = tFind;
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = tReplace;

            object replaceAll = Word.WdReplace.wdReplaceAll;
            findObject.Execute(ref mMissing, ref mMissing, ref mMissing, ref mMissing, ref mMissing,
        ref mMissing, ref mMissing, ref mMissing, ref mMissing, ref mMissing,
        ref replaceAll, ref mMissing, ref mMissing, ref mMissing, ref mMissing);
        }
    }
}
