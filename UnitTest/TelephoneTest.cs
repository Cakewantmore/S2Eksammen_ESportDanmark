using ESportDanmark.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class TelephoneTest
    {
        
        [TestMethod]
        public Boolean checkNumberExists(int telephone)
        {
            BaseRepository baseRepository = new BaseRepository();
            bool result = false;
            string selectQuery = $"SELECT FROM Spillere WHERE Telephone ={ telephone}";
            DataSet checkNumber = baseRepository.Execute(selectQuery);
            if (checkNumber == null)
            {
                selectQuery = $"SELECT FROM Ansatte WHERE Telephone ={telephone}";
                checkNumber = baseRepository.Execute(selectQuery);
                if (checkNumber != null)
                {
                    result = true;
                }

            }
            else
            {
                result = true;
            }
            Assert.IsTrue(result = false);
            return result;
            

        }
    }
}
