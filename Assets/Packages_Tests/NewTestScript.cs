using NUnit.Framework;
using UnityEngine.InputSystem;

namespace Tests
{
    public class NewTestScript : InputTestFixture
    {
        // A Test behaves as an ordinary method
        [Test]
        public void NewTestScriptSimplePasses()
        {
            var gamepad = InputSystem.AddDevice<Gamepad>();
            Press(gamepad.buttonSouth);
        }
    }
}