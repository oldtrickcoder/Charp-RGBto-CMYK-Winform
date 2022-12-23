using System;

public class HexValidator
{
. . .

// the following function is needed to used to verify the input
public static HexValidator Parse(string s)
    {
        // remove any spaces
        s = s.Replace(" ", "");

        string[] strParts = s.Split('-');
        int nValue;

        foreach (string part in strParts)
        {
            bool result = int.TryParse(part, System.Globalization.NumberStyles.AllowHexSpecifier, null, out nValue);
            if (false == result)
                throw new ArgumentException(string.Format("The provided string {0} is not a valid subnet ID.", s));
        }

        return new SubnetID(strParts[0], strParts[1]);
    }
}

/// set as following to associate them
maskedTextBox1.ValidatingType = typeof(HexValidator);

// in  the validationcomplete event, you could judge if the input is valid
private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
{
    if (e.IsValidInput)
    {
        //AppendLog("Type validation succeeded.  Message: " + e.Message);                
    }
    else
    {
        toolTip1.Show(e.Message, maskedTextBox1, maskedTextBox1.Location, 5000);
    }
}