namespace seminar3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FamilyMember grantFatherFirst = new FamilyMember()
            {
                FullName = "FooFooFoo",
                Age = 50,
                Gender = Gender.man
            };

            FamilyMember grantMotherFirst = new FamilyMember()
            {
                FullName = "NooNooNoo",
                Age = 53,
                Gender = Gender.woman
            };

            FamilyMember grantFatherSecond = new FamilyMember()
            {
                FullName = "DooDooDoo",
                Age = 55,
                Gender = Gender.man
            };

            FamilyMember grantMotherSecond = new FamilyMember()
            {
                FullName = "LooLooLoo",
                Age = 48,
                Gender = Gender.woman
            };

            FamilyMember Father = new FamilyMember()
            {
                FullName = "Jack",
                Age = 30,
                Gender = Gender.man,
                Father = grantFatherFirst,
                Mother = grantMotherFirst,
                

            };

            FamilyMember Mother = new FamilyMember()
            {
                FullName = "Lili",
                Age = 33,
                Gender = Gender.woman,
                Father = grantFatherSecond,
                Mother = grantMotherSecond,
                
            };

            FamilyMember Son = new FamilyMember()
            {
                FullName = "Bill",
                Age = 14,
                Gender = Gender.man,
                Mother = Mother,
                Father = Father

            };

            //var parents = Father.GetWifeAndHusband();

            //parents[0]?.Print();
            //parents[1]?.Print();

            Father.Married = Mother;
            Mother.Married = Father;

            Father.DisplayCloseRelatives();
            Mother.DisplayCloseRelatives();

            Son.DisplayCloseRelatives();




        }
    }
}
