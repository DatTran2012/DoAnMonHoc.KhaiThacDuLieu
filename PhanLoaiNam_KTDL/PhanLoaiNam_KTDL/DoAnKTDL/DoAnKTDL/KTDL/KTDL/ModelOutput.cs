using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ML.Data;

namespace KTDL
{
    public class ModelOutput
    {
        [ColumnName("PredictedLabel")]
        public String Prediction { get; set; }
        public float[] Score { get; set; }
    }
}
