using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//extentin is 
public static class SGTransformExtention
{
    
    // ��ġ �ʱ�ȭ ������ �� �ִ´�
    public static void ResetTransfrom(this Transform self , bool worldSpace = false)
    {
        self.ResetPosition()
            self.Resetlocation()
            self.ResetPosition()
    }

    public static void ResetPosition(this Transform self , bool worldSpace = false)
    {
        if (worldSpace)
        {
            
        }
    }

    public static void ResetPosition(this Transform self, bool worldSpace = false)
    {
        if (worldSpace)
        {
            
        }
    }

    public static void Resetlocation(this Transform self, bool worldSpace = false)
    {
        
    }

    public static void Resetlocation(this Transform self)
    {
        Vector3 selfAngle = self
    }
}
