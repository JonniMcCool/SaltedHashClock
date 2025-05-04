namespace SaltAndHash
open System.Security.Cryptography;

module Encryption =
    let dateFormat : string = "yyyy-MM-dd HH:mm:ss"

    let Salt (date: System.DateTime) (userSalt: string) : string =
        String.concat "" (List.toSeq ["The"; date.Date.ToString(dateFormat); "Salted"; userSalt; "Hash"; date.TimeOfDay.ToString(@"hh\:mm\:ss"); "Clock"])

    let Hash (saltedInput: string) : string =
        let hashBytes = System.Text.Encoding.UTF8.GetBytes(saltedInput) |> SHA256.Create().ComputeHash
        System.BitConverter.ToString(hashBytes).Replace("-", "").ToLower()

    let Execute (date: System.DateTime) (userSalt: string) : string =
        let salted = Salt date userSalt
        Hash salted


//module Validation =
//    let Execute =
//        
//