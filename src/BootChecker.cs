using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nebula;

public class BootChecker : UnityEngine.MonoBehaviour
{
    public BootChecker(System.IntPtr intPtr) : base(intPtr) { }
    
    private void Update()
    {
        if (SceneManager.GetActiveScene().name != "Boot")
        {
            GameInfo.IsBooted = true;
            Destroy(this);
        }
    }
}
