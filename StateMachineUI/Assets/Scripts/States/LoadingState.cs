using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingState : MonoBehaviour, IState
{

    #region |  [ Fields ] |

    StateManagerBase stateManagerBase;

    #endregion


    #region  |  Mehtods  [ Public ]  |

    public void Begin(StateManagerBase stateManagerBase)
    {
        this.stateManagerBase = stateManagerBase;
        this.gameObject.SetActive(true);
        StartCoroutine(LoadingStarted());
    }

    public void Exit()
    {
        this.gameObject.SetActive(false);
    }

    #endregion

    #region  |  Mehtods  [ Private ]  |
    IEnumerator LoadingStarted()
    {
        yield return new WaitForSeconds(0.5f);
        this.stateManagerBase.ChangeState(UIState.GAME_PLAY);
    }

    #endregion
}

