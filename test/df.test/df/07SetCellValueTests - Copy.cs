using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using Daany;

namespace Unit.Test.DF
{
    public class SetCellValueTests
    {
       
      

        [Fact]
        public void SetCellValue_Test01()
        {

            int row = 10;
            int nCols = 10;
            var nd = nc.ConsecutiveNum(row, nCols);
            var cols = Enumerable.Range(1, nCols).Select(x => $"col{x}").ToList();

            var df = new DataFrame(nd, cols);

            //
            var cell1 = (int)df["col1", 1];
            Assert.Equal(11, cell1);
            df["col1", 1] = 111;
            cell1 = (int)df["col1", 1];
            Assert.Equal(111, cell1);

            //
            var cell = df["col3", 5];
            Assert.Equal(53, (int)cell);
            df["col3", 5] = 555;
            cell = df["col3", 5];
            Assert.Equal(555, (int)cell);


            cell = df[1, 1];
            Assert.Equal(12, (int)cell);
            df[1, 1] = "str";
            var vall = df[1, 1];
            Assert.Equal("str", vall.ToString());


            cell = df[4, 3];
            Assert.Equal(44, (int)cell);
            df[4, 3] = 4444;
            cell = df[4, 3];
            Assert.Equal(4444, (int)cell);

            var cell2 = df[2, 8];
            Assert.Equal(29, (int)cell2);
            df[2, 8] = 2.345;
            cell2 = df[2, 8];
            Assert.Equal(2.345, (double)cell2);
        }

        
    }
}
