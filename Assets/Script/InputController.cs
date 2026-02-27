using UnityEngine;

public class InputController : MonoBehaviour
{
    [Header("모바일 전용 UI")]
    public GameObject joystickCanvas;
    public Joystick joystick;

    [Header("플레이어")]
    public PlayerScript playerScript;

    void Awake()
    {
        // 네이티브 모바일이거나 터치 지원 기기(모바일 브라우저 WebGL)이면 모바일로 판단
        bool isMobile = Application.isMobilePlatform || Input.touchSupported;

        if (joystickCanvas != null)
            joystickCanvas.SetActive(isMobile);

        if (playerScript != null)
            playerScript.SetJoystick(isMobile ? joystick : null);
    }
}
