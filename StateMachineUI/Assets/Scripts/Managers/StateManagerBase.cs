using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateManagerBase : MonoBehaviour
{
    #region |  [ Fields ] |

    protected List<IState> statesList = new List<IState>();
    public Transform uiParentTransform;

    #endregion

    #region  |  Mehtods  [ Call Backs ]  |

    public virtual void Awake()
    {
      
    }

    void Start()
    {

    }


    void Update()
    {

    }

    #endregion

    #region  |  Mehtods  [ Public ]  |

    public abstract void ChangeState(Enum statesEnum);


    public virtual void LoadUIPanels()
    {
        foreach (Transform trans in uiParentTransform)
        {
            if (trans.GetComponent<IState>() != null)
            {
                statesList.Add(trans.GetComponent<IState>());
                trans.gameObject.SetActive(false);
            }
        }
    }

    #endregion

    #region  |  Mehtods  [ Private ]  |

    #endregion
}
