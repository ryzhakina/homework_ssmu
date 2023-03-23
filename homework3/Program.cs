namespace homework3;

using System;

class Program
{
    static void Main(string[] args)
    {
        Patient patient = new("Виктор", 26);
        Doctor doctor = new("Игорь Николаевич", 18, 25);

        while (true) {
            patient.KnockOnTheDoor(doctor);

            if (doctor.IsFreedom())
            {
                doctor.Say("Я свободен, можете входить");
                patient.Say("Здравствуйте, доктор..");
                doctor.Say($"Здравствуйте, {patient.Name}!");
                patient.Say("Я заболел..");

                doctor.Cure(patient);

                break;
            }
            else
            {
                doctor.Say("Я занят, подождите");
                patient.Say("Хорошо, зайду позже");
            }
        }
    }
}
