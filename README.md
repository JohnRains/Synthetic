# Synthetic
This is a simple Windows Forms application implementing the Person part of the C# Bogus library (which is based on the Faker.js library). A full implementation of Bogus can be seen in the FrankenPeople repository. The application presents the most commonly used PII for use in testing various forms while maintaining compliance.

Known issues:
	The four calls to Title, First, Middle and Last names pass in Gender but the 
	returned values are occasionally disregard. This is also reported as an issue with Faker.js.
