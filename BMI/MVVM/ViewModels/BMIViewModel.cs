


namespace BMI.MVVM.ViewModels
{
    public class BMIViewModel
    {
        public Models.BMI Bmi{ get; set; }

        public BMIViewModel()
        {
            Bmi = new Models.BMI();
            Bmi.Height = 180;
            Bmi.Weight = 89;
        }
    }
}
