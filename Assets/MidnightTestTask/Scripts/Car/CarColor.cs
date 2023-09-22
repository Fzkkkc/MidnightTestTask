using UnityEngine;

namespace MidnightTestTask.Scripts.Car
{
    public class CarColor : MonoBehaviour
    {
        [SerializeField] private Material _carMaterial;
        
        private const string PlayerPrefsKey = "CarColor";
        
        private void Start()
        {
            SetCarColor();
        }

        private void SetCarColor()
        {
            int carColor = PlayerPrefs.GetInt(PlayerPrefsKey); 

            switch (carColor)
            {
                case 1: 
                    _carMaterial.color = Color.white;
                    break;
                case 2: 
                    _carMaterial.color = Color.blue;
                    break;
                case 3: 
                    _carMaterial.color = Color.green;
                    break;
            }
        }
    }
}
