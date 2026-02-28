using UnityEngine;
using UnityEngine.InputSystem;

public class basicScript : MonoBehaviour
{
  private void Start()
  {
    print("Hello, world!");
  }

  private void Update()
  {
    Keyboard keyboard = Keyboard.current;
    if (keyboard.spaceKey.isPressed())
    {
      print("Должен быть прыжок");
    }
  }
}
