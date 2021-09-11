using NUnit.Framework;

namespace FaceBook_Automation_Demo
{
    public class Tests : Base.BaseClass1
    {

        [Test, Order(1)]
        public void InputEmailAndPassword_into_InputFields()
        {
            DoActions.DoActions.AssertAfterLaunching(driver);
            DoActions.DoActions.LoginToFacebook(driver);


        }

    }
}