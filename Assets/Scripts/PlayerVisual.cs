using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private Animator animator;

    private const string IS_RUNNING = "isRunning";
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        bool isRunning = Player.Instance.IsRunning();
        animator.SetBool(IS_RUNNING, isRunning);
    }

}
