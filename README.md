# The Salted Hash Clock

Inspired by a problem posed in episode "108 = Proofed Mates and Proved Dates" of the "A Problem Squared" podcast by Bec Hill and Matt Parker.
Link: https://podcasts.apple.com/de/podcast/108-proofed-mates-and-proved-dates/id1490290676?i=1000705187520

You want to prove you had an idea before a certain date?
Easy: put the jist of your idea into the "Input Text" field, click the button below.
Copy the hash and the hash date.
When somebody asks you to prove, just show them the hash, the jist of your idea and the hash data.
They can now input this into the validation section, and if the hash is valid, the checkbox will be ticket.

## Why does this work?

When hashing, the input text gets mangled with the date and a "secret" additional text.
Since the time is taken from the operating system and not a user input, one would need to modify the os time to generate a hash for a specific time.
Thus, no user can know the result hash in advance except by brute forcing with the validation function.

## Caveats

Since this code is public, the mangling and "secret" additional text are known, this is currently not trutworthy.
Also, the time is taken from the os.

To get this into a workable state, a public service would need to be setup with a differnt salting function and truly secret additional text.
Also, the time should not be taken from the os, but the actual "now" from a different service.
Then, everybody can use the hashing to proof their ideas.
Excpept for the service provider, since they of course know the sectret text and mangling function.
