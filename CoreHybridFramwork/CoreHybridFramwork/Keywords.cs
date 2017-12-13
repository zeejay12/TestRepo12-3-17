using ExcelReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*This class will read data from Excel file which we created
 * 
 */

namespace CoreHybridFramwork
{
    class Keywords
    {
        
        public void executeKeywords(string testUnderExecution, ExcelReaderFile xls)
        {
            
            GenericKeywords app = new GenericKeywords();
            
            //reading the data from excel
            xls = new ExcelReaderFile(Constants.SUITEA_XLS);
            int rows = xls.getRowCount(Constants.KEYWORDS_SHEET);
            for (int rowNum = 2 ; rowNum <= rows; rowNum++)
            {
              
                //iterate thru the excel sheet and assign the keywords 
                string tcid = xls.getCellData(Constants.KEYWORDS_SHEET, Constants.TCID_COL, rowNum);
                if (tcid.Equals(testUnderExecution))
                {  
                    //Assigning data from the cells to the variables
                    string keyword = xls.getCellData(Constants.KEYWORDS_SHEET,Constants.KEYWORDS_COL, rowNum);
                    string objct = xls.getCellData(Constants.KEYWORDS_SHEET,Constants.OBJECT_COL, rowNum);
                    string data = xls.getCellData(Constants.KEYWORDS_SHEET,Constants.DATA_COL,rowNum);
                    Console.WriteLine(tcid + "---" + keyword + "---" + objct +"---"+ data);
                    //opening the browser and passing the data
                    if (keyword.Equals("OpenBrowser"))                    
                        app.OpenBrowser(data);                   
                    else if (keyword.Equals("Navigate"))                    
                        app.Navigate(objct);
                    else if(keyword.Equals("Input"))
                        app.Input(objct, data);
                    else if(keyword.Equals("Click"))
                        app.Click(objct);                    

                }             

            }
            
        }

    }
}
