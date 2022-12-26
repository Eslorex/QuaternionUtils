public static class QuaternionUtils
{
    public static float QuaternionDeriver(this Quaternion q)
    {
            roll  = Mathf.Atan2(2*y*w - 2*x*z, 1 - 2*y*y - 2*z*z);
            pitch = Mathf.Atan2(2*x*w - 2*y*z, 1 - 2*x*x - 2*z*z);
            yaw   =  Mathf.Asin(2*x*y + 2*z*w);
    }
}