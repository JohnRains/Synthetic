# Synthetic
This is a simple Windows Forms application implementing the Person part of the C# Bogus library (which is based on the Faker.js library). A full implementation of Bogus can be seen in the FrankenPeople repository. The application presents the most commonly used PII for use in testing various forms while maintaining compliance.

In 2013, working as the only QA engineer for a FinTech company, I needed synthetic data to test web apps and APIs. Faker.js has origins of other works dating back to 2004, none of which were suitable for what I needed - an identity that had a high probability of passing risk evaluation. The approach I took was to gather massive amounts of data into discreet tables, accessed by SQL stored procedures and ensuring a high degree of reference integrity, e.g. a zip code that is valid for the declared state, or an area code / exchange that is valid for the declared city, or an IP, valid for an ISP serving that area. These SPs were consumed by C# and VB.net wrappers for desktop tools and continuous automated testing.

I am not happy that Synthetic meets the requiremet of reference integrity. Faker.js has API methods like zipCodeByState, giving some confidence that it supports reference integrity but I have scanned through the code of Bogus and cannot find this or an equivalent method. Consequently, a Synthetic identity does not have reference integrity

Known issues:
	The four calls to Title, First, Middle and Last names pass in Gender but for the 
	returned values, gender is occasionally disregarded. This is also reported as an issue with Faker.js.

	
