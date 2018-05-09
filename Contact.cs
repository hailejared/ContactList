using System;


namespace ContactList
{
    class Contact
    {
        // Setting variables.
        private string firstName;
        private string lastName;
        private string phone;

        // Initiating variable 'firstName'.
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Initiating variable 'lastName'.
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Initiating variable 'phone' and setting parameter.
        public string Phone
        {
            get { return phone; }
            set {
                if (value.Length == 10)
                {
                    phone = value;
                }
                else
                {
                    phone = "0000000000";
                }
            }
        }

        // Setting values.
        public Contact()
            {
                FirstName = "John";
                LastName = "Doe";
                Phone = "0000000000";
            }

        // *Learn*
        public Contact(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        // Setting string output.
        public override string ToString()
        {
            string output = String.Empty;

            output += String.Format("{0}, {1} ", LastName, FirstName);
            output += String.Format("({0}) {1}-{2}", Phone.Substring(0,3), Phone.Substring(3,3), Phone.Substring(6,4));

            return output;
        }


    } // End of the class.

} // End of the 'namespace'.
