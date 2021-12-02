using System;

namespace RegisterPages.Model
{
    interface VerificationResponse
    {
        void OnEmailVerificationSucceed(object source, EventArgs e);
        void OnWaVerificationSucceed(object source, EventArgs e);
    }
}