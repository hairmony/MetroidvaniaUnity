using UnityEngine;
using UnityEngine.Events;

public class GrantAbilityTrigger : MonoBehaviour
{
    public enum AbilityToGrant
    {
        None,
        CanDoubleJump,
        CanTimeSlow,
        CanRoll
    }

    public AbilityToGrant abilityToGrant;
    public bool destroyOnTrigger = true;
    public GameObject playerToGrant;
    public UnityEvent onTriggerActivated;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        bool playerIsAllowed = false;

        if (playerToGrant != null)
        {
            if (collision.gameObject == playerToGrant)
            {
                playerIsAllowed = true;
            }
        }
        else
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                playerIsAllowed = true;
            }
        }

        if (playerIsAllowed)
        {
            PlayerMovement playerMovement = collision.gameObject.GetComponent<PlayerMovement>();

            if (playerMovement != null)
            {
                switch (abilityToGrant)
                {
                    case AbilityToGrant.CanDoubleJump:
                        playerMovement.canDoubleJump = true;
                        break;

                    case AbilityToGrant.CanTimeSlow:
                        playerMovement.canTimeSlow = true;
                        break;

                    case AbilityToGrant.CanRoll:
                        playerMovement.canRoll = true;
                        break;

                    case AbilityToGrant.None:
                        break;
                }

                if (onTriggerActivated != null)
                {
                    onTriggerActivated.Invoke();
                }

                if (destroyOnTrigger)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}