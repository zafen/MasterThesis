using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace MasterThesis
{
    class Plot
    {
        public Plot(Chart chart, List<double> list, double dataPoints, double futureValues)
        {
            chart.Series.Clear();
            chart.Series.Add("Series0");
            chart.Series.Add("Series1");
            chart.Series[0].ChartType = SeriesChartType.Point;
            chart.Series[1].ChartType = SeriesChartType.Line;
            chart.Legends.Clear();

            for (double x = 0; x < dataPoints; x++)
            {
                chart.Series[0].Points.AddXY(x, Calculate.CalculatePolynom(list, x));
            }

            for (double x = 0; x < dataPoints + futureValues; x++)
            {
                chart.Series[1].Points.AddXY(x, Calculate.CalculatePolynom(list, x));
            }

        }
    }
}
