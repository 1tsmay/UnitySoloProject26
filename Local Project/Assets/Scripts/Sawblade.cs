using UnityEngine;
using UnityEngine.UIElements;





public class Permaspin : MonoBehaviour
{
    private object sawblade;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


        
    }
}

public class TorqueRotationExample : MonoBehaviour
{
    private const int AngChange = 1;

    public class Permaspin : MonoBehaviour
    {
        // Add an impulse which produces a change in angular velocity (specified in degrees).
        // Whats an impulse 
        public void AddTorqueImpulse(float AngChange)
        {
            var body = GetComponent<Rigidbody2D>();
            var impulse = (AngChange * Mathf.Deg2Rad) * body.inertia;

            body.AddTorque(impulse, ForceMode2D.Impulse);
        }
    }
}
