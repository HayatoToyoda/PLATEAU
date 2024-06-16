using UnityEngine;
using UnityEngine.InputSystem;


//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
/// <summary>
/// キャラクター変更クラス.
/// </summary>
/// <remarks>
/// </remarks>
//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

public sealed class CharacterChanger : MonoBehaviour
{
    //================================================================================
    // Fields.
    //================================================================================

    /// <summary>
    /// 各キャラクターのオブジェクト.
    /// </summary>
    [SerializeField] private GameObject[] CharacterObjects = default;

    /// <summary>
    /// 各キャラクターのアバター.
    /// </summary>
    [SerializeField] private Avatar[] CharacterAvatars = default;

    /// <summary>
    /// アニメーター.
    /// </summary>
    [SerializeField] private Animator Animator = default;

    /// <summary>
    /// 現在のキャラクターのインデックス.
    /// </summary>
    private int CharacterIndex = default;

    //================================================================================
    // Methods.
    //================================================================================

    //--------------------------------------------------------------------------------
    // MonoBehaviour
    //--------------------------------------------------------------------------------

    private void Update()
    {
        if      (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            CharacterIndex = 0;
            ChangeCharacter();
        }
        else if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            CharacterIndex = 1;
            ChangeCharacter();
        }
        else if (Keyboard.current.digit3Key.wasPressedThisFrame)
        {
            CharacterIndex = 2;
            ChangeCharacter();
        }

        void ChangeCharacter()
        {
            foreach (var obj in CharacterObjects)
            {
                obj.SetActive(false);
            }

            CharacterObjects[CharacterIndex].SetActive(true);
            Animator.avatar = CharacterAvatars[CharacterIndex];
        }
    }
}
