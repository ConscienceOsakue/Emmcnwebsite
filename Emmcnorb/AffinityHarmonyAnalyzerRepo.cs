using Humanizer;
using System.Data;
using static Google.Protobuf.WellKnownTypes.Field.Types;
using System.Drawing;
using System.Text;

namespace Emmcnorb
{
    public class AffinityHarmonyAnalyzerRepo
    {
       private readonly IDbConnection _conn;

        public AffinityHarmonyAnalyzerRepo(IDbConnection conn)
        {
            _conn = conn;
        }

        public static void AffinityHarmonyMeter()
        {
           /* Accounding to Bible Scripture. 1 Corinthians 13:4–8a(ESV) Love is patient and kind,love does not envy or boast
        it is not arrogant or rude.It does not insist on its own way it is not irritable or resentful
        it does not rejoice at wrongdoing, but rejoices with the truth*/

            int userPartnerRatingPatient;
            int userPartnerRatingKind;
            int userPartnerRatingLove;
            int userPartnerRatingHumble;
            int userPartnerRatingRespectful;
            int userPartnerRatingGiving;
            int userPartnerRatingHonest;

            int userSelfRatingPatient;
            int userSelfRatingKind;
            int userSelfRatingLove;
            int userSelfRatingHumble;
            int userSelfRatingRespectful;
            int userSelfRatingGiving;
            int userSelfRatingHonest;

            int userPartnerTotalScore;
            int userSelfTotalScore;

            Console.WriteLine("Hey dear, AffinityHarmonyAnalyzer will ask you 7 questions to calculate compatablity of Your partner and yourself\n" +
                "Please rate each question from a scale from 1 to 10 Be as Honest as possible to get an accurate Harmony.");

            Console.WriteLine("On a scale of 1 to 10, how patient is your partner with you?");
            userPartnerRatingPatient = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("How kind has your partner been to you?");
            userPartnerRatingKind = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Has your Partner been sincerly loving towards you?");
            userPartnerRatingLove = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Is your partner humble?");
            userPartnerRatingHumble = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("How respectful is your partner towards you and your family?");
            userPartnerRatingRespectful = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Is your partner giving towards you?");
            userPartnerRatingGiving = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Is your partner honest with you?");
            userPartnerRatingHonest = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("These next questions are for you to give a truthful rating of yourself.\n " +
                "AffinityHormonyAnalyzer will ask you 7 questions please be Honest! Rate yourself on a sacle from 1 to 10");
            Console.WriteLine();

            Console.WriteLine("How Patient are you with your Partner?");
            userSelfRatingPatient = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Are you kind to your partner?");
            userSelfRatingKind = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("How inlove are you with your Partner?");
            userSelfRatingLove = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Are you humble?");
            userSelfRatingHumble = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Do you respect your partner");
            userSelfRatingRespectful = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Are you are giving person?");
            userSelfRatingGiving = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Lastly, how honest are you?");
            userSelfRatingHonest = int.Parse(Console.ReadLine());

            userPartnerTotalScore = (userPartnerRatingPatient + userPartnerRatingKind + userPartnerRatingLove +
                userPartnerRatingHumble + userPartnerRatingRespectful + userPartnerRatingGiving + userPartnerRatingHonest);

            userSelfTotalScore = (userSelfRatingPatient + userSelfRatingKind + userSelfRatingLove + userSelfRatingHumble +
                userSelfRatingRespectful + userSelfRatingGiving + userSelfRatingHonest);

            if(userPartnerTotalScore < 50 || userSelfTotalScore < 50)
            {
                Console.WriteLine("You are a match");
            }
            
            // calculator(); this is what i use to call it in main.
        }
    }
}
