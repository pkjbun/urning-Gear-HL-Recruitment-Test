using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class MouseAngleProvider : MonoBehaviour, IDragHandler,IBeginDragHandler, IInitializePotentialDragHandler {

    #region Public Fields

    public UnityEvent<float> OnAngleChanged;
    #endregion
    #region Private Fields
    [SerializeField] private float angleStart;
    [SerializeField] private float AngleCurrent;
    [SerializeField] Vector3 StartMousePosition;
    [SerializeField] float lastCalled = 0f;
    [SerializeField] float diff;
    [SerializeField] bool OnObject;
    #endregion
    #region Unity Methods
 
   public void OnBeginDrag(PointerEventData eventData)
    {
        CalculateInitialAngle();
    }

    public void OnDrag(PointerEventData eventData)
    {
        CalculateCurrentAngle();

    }



    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        eventData.useDragThreshold = false;
    }

  

    #endregion
    #region MyMethods 
    private void CalculateInitialAngle()
    {
        StartMousePosition = Input.mousePosition;
        angleStart = Mathf.Atan((StartMousePosition.x - (Screen.width / 2)) / (StartMousePosition.y - Screen.height / 2)) * Mathf.Rad2Deg;
        lastCalled = 0;
        OnObject = true;
    }
    private void CalculateCurrentAngle()
    {
        AngleCurrent = Mathf.Clamp(Mathf.Atan((Input.mousePosition.x - (Screen.width / 2)) / (Input.mousePosition.y - Screen.height / 2)) * Mathf.Rad2Deg, -180f, 180f);
        diff = Mathf.Clamp((AngleCurrent - angleStart) - lastCalled, -1f, 1f);
        lastCalled = (AngleCurrent - angleStart);

        OnAngleChanged?.Invoke(diff);
    }
    #endregion
}
