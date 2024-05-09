namespace Lab5._1Lib
{
    public class ClassLib1
    {
        public class Country
        {
            public string Name;
            public string Capital;
            public long Population;
            public double Area;
            public string Language;
            public bool IsUNMember;
            public string DevelopmentLevel;
            public double PopulationDensity
            {
                get
                {
                    return GetPopulationDensity();
                }
            }

            public double GetPopulationDensity()
            {
                return Population / Area;
            }
        }
    }
}