using focus_aid.BusinessLogic;
using System.Runtime.CompilerServices;

namespace focus_aid.BusinessLogicTests
{
    public class CountdownSessionManagerUnitTests
    {
        public int InitializedSeconds = 3600;
        [Test]
        public void Start_InitializesSecondsPropertiesAndDelegatesToUI_ReturnsTrue()
        {
            // Arrange
            var csm = new CountdownSessionManager();

           // Act

           // Assert
        }
    }
}