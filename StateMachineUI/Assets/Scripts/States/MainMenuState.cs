using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : MonoBehaviour, IState
{

    #region |  [ Fields ] |

    StateManagerBase stateManagerBase;

    #endregion


    #region  |  Mehtods  [ Public ]  |

    public void Begin(StateManagerBase stateManagerBase)
    {
        this.stateManagerBase = stateManagerBase;
        Show();
    }

    public void Exit()
    {
        Hide();
    }

    public void OnStartButtonClicked()
    {
        this.stateManagerBase.ChangeState(UIState.LEVEL_SELECTION);
    }

    public void OnSettingButtonClicked()
    {
        this.stateManagerBase.ChangeState(UIState.SETTING);

    }

    #endregion

    #region  |  Mehtods  [ Private ]  |

    private void Show()
    {
        this.gameObject.SetActive(true);
    }

    private void Hide()
    {
        this.gameObject.SetActive(false);
    }

    #endregion
}
