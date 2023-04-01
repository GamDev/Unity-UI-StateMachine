using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsState : MonoBehaviour , IState
{

    #region |  [ Fields ] |

    StateManagerBase stateManagerBase;
    public Text soundButtonTxt;
    bool isSoundOff = false;
    #endregion


    #region  |  Mehtods  [ Public ]  |

    public void Begin(StateManagerBase stateManagerBase)
    {
       this.stateManagerBase = stateManagerBase;
        this.gameObject.SetActive(true);
    }

    public void Exit()
    {
        this.gameObject.SetActive(false);
    }

    public void OnBackButtonClicked()
    {
        this.stateManagerBase.ChangeState(UIState.MAIN);
    }

    public void OnSoundOnOffButtonClicked()
    {
        isSoundOff = !isSoundOff;
        soundButtonTxt.text = isSoundOff ? "Sound Off" : "Sound On";
    }

    #endregion

    #region  |  Mehtods  [ Private ]  |

    #endregion
}
