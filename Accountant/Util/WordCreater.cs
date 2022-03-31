using Accountant.Objects;
using System.Data;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;


namespace Accountant.Util
{
    public static class WordCreater
    {
        private const string TemplateFile = "Template.docx";
        private const string TemplateFolder = "Template";
        private static object TemplatePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), TemplateFolder, TemplateFile);

        private static object mMissing = Missing.Value;
        private static Word.Application? aWord ;
        private static Word.Document? document;

        public static void CreateWord(CustomerObject tCustomer ,List<ProductObject> tProductList)
        {
            aWord = new Word.Application();

            document = aWord.Documents.OpenNoRepairDialog(TemplatePath);

            document.Activate();

            if(string.IsNullOrEmpty(tCustomer.CompanyName) == false)
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

            int aRowIndex = 1;

            for(int aIndex = 0; aIndex < tProductList.Count; aIndex++)
            {
                int aCellIndex = 1;

                aTable.Cell(aRowIndex, aCellIndex).Range.Text = tProductList[aIndex].Name.ToString();
                aCellIndex++;
                aTable.Cell(aRowIndex, aCellIndex).Range.Text = tProductList[aIndex].Price.ToString();
                aCellIndex++;
                aTable.Cell(aRowIndex, aCellIndex).Range.Text = tProductList[aIndex].Weight?.ToString();
                aRowIndex++;
                aTable.Rows.Add();
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
