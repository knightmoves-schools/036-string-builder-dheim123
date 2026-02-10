namespace knightmoves;

public class Person {
   private string firstName;
   private string lastName;

   public Person(string firstName, string lastName){
      this.firstName = firstName;
      this.lastName = lastName;
   }

   public string BuildFullName() {
      StringBuilder sb = new StringBuilder();
      sb.Append(firstName);
      sb.Append(" ");
      sb.Append(lastName);
      return sb.ToString();
   }
}
}
