using UnityEngine;

public class GroundCheck : MonoBehaviour{
    public bool IsGrounded{ get; private set; }

    [SerializeField] float groundCheckLength = 1;
    [SerializeField] LayerMask groundLayer;
    Vector3 pos;

    void Start(){
        pos = transform.position;
    }

    void Update(){
        var pos = transform.position;
        var ray = new Ray(pos, Vector3.down);
        IsGrounded = Physics.Raycast(ray, groundLayer);
    }
}
