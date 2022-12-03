using UnityEngine;
using ECM.Controllers;

public class Player : BaseCharacterController
{
    #region METHODS

    /// <summary>
    /// Overrides 'BaseCharacterController' HandleInput,
    /// to perform custom controller input.
    /// </summary>

    protected override void HandleInput()
    {
        moveDirection = new Vector3
        {
            x = Input.GetAxisRaw("Horizontal"),
            y = 0.0f,
            z = Input.GetAxisRaw("Vertical")
        };
        jump = Input.GetButton("Jump");
    }

    #endregion
}
