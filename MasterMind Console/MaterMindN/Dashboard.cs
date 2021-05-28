using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace masterMind
{
    class Dashboard
    {
        private int rows;
        private int columns;
        public Dashboard()                 //size of dashboard n rows and columns
        {
            rows = 10;
            columns = 4;
        }
        public int GetRows()                                    //get Rows
        {
            return this.rows;
        }
        public void SetRows(int rows)                                    //get Rows
        {
            this.rows = rows;
        }
        public int GetColumns()                                 //get Columns
        {
            return this.columns;
        }
    }
}
