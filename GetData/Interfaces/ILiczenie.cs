using System;
using System.Collections.Generic;
using System.Text;

namespace GetData
{
    public interface ILiczenie
    {
        double Testowa(List<Values> dane);
        double TotalDistance(List<Values> dane);
        double ClimbingDistance(List<Values> dane);
        double DescentDistance(List<Values> dane);
        double FlatDistance(List<Values> dane);
        
        double MinimumSpeed(List<Values> dane);
        double MaximumSpeed(List<Values> dane);
        double AverageSpeed(List<Values> dane);
        double AverageClimbingSpeed(List<Values> dane);
        double AverageDescentSpeed(List<Values> dane);
        double AverageFlatSpeed(List<Values> dane);

        void MinimumElevation();
        void MaximumElevation();
        void AverageElevation();
        void TotalTrackTime();
        void TotalDescent();
        void FinalBalance();
        void ClimbingTime();
        void DescentTime();
        void FlatTime();
        
    }
}
