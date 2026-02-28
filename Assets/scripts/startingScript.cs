using UnityEngine;
using UnityEngine.InputSystem;

public class startingScript : MonoBehaviour
{
    [SerializeField] private Material material1;
    [SerializeField] private Material material2;
    [SerializeField] private float jumpForce = 5f;
    
    private Rigidbody rb;
    private Renderer objectRenderer;
    private bool isMaterial1;
    
    private void Start()
    {
        print("Hello, world!");

        rb = GetComponent<Rigidbody>();
        objectRenderer = GetComponent<Renderer>();
    
        objectRenderer.material = material1;
        isMaterial1 = true;
    }
    private void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard.spaceKey.isPressed)
        {
            print("Должен быть прыжок");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            print("Прыжок выполнен!");
            
            if (isMaterial1 && material2 != null)
            {
                objectRenderer.material = material2;
                isMaterial1 = false;
                print("Цвет переключен на второй");
            }
            else if (!isMaterial1 && material1 != null)
            {
                objectRenderer.material = material1;
                isMaterial1 = true;
                print("Цвет переключен на первый");
            }
            
        }
    }
}