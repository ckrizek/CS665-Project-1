# Database Description

<a name="contents"></a>
## Contents

* [Database Overview](#database-overview)
* [Tables](#tables)
* [Attributes](#attributes)
* [Primary Keys](#primary-keys)
* [Foreign Keys](#foreign-keys)
* [Triggers and Policies](#trigger)
* [3NF](#3nf)
* [Sample Data](#sample-data)

***

<a name="database-overview"></a>
## Database Overview

* My database is based off my Senior Design project Roomers. Roomers is a web-based application to ease the frustrations of having a roommate.
* The general requires for this database is to fulfill basic requirements of our site. Our three major features for this application are...

  1. A financial tab that helps roommates navigate splitting, paying, and staying on time with bills.
  2. A calendar tab that will sync roommates calendars to allow each other to know when others will be home, when they have class, and other general calendar information.
  3. A communication system that will allow roommate to roommate as well as roommate to landlord communication. This will ease the stress of giving out personal information such as cell phones numbers but allow open communication throughout the household.

* The layout of my database will be widely based off general personal information, log in, and sign-up details. As this is an extensive data for project, I will focus strictly on building the initial user databases for the CS665 Project.

<a name="tables"></a>
# Tables

* The following allow our application Roomers to store data on roommates, landlord, and the link of different features to those users.

#### Table 1 (Roommate)
* Roommate table will help organize all personal information relating to roommate users. The table will have a Roommate ID(rid), Name(name), Username(username), Password(passwd), Email(email), Creation date(created_at), Gender(gender), Address(addr), State(state), Country(country).

#### Table 2 (LandLord)
* Landlords table will help organize all personal information relating to landlord users. The table will have a Landlord ID(lid), Name(name), Username(username), Password(passwd), Email(email), Creation date(created_at), Gender(gender), Address(addr), State(state), Country(country).

#### Table 3 (Login)
* Login table will be utilized for roommates and landlords to be able to log into the application. This table will include Roommate ID(rid), Landlord ID(lid), Username(username), Password(passwd), Remember login(rememb_login).

#### Table 4 (Signup)
* Sign up table will be utilized for roommates or landlords to be able to sign up for the first time. The table will have a Roommate ID(rid), Landlord ID(lid), Name(name), Username(username), Password(passwd), Email(email), Creation date(created_at), Gender(gender), Address(addr), State(state), Country(country).

<a name="attributes"></a>
# Attributes

#### Table 1 (Roommate)
* Roommate ID(rid), int
* Name(name), string
* Username(username), string
* Password(passwd), string
* Email(email), string
* Creation date(created_at), date
* Gender(gender), bool
* Address(addr), string
* State(state), string
* Country(country), string
* ZIP Code(zip), int

#### Table 2 (LandLord)
* Landlord ID(lid), int
* Name(name), string
* Username(username), string
* Password(passwd), string
* Email(email), string
* Creation date(created_at), date
* Gender(gender), bool
* Address(addr), string
* State(state), string
* Country(country), string
* ZIP Code(zip), int

#### Table 3 (Login)
* Roommate ID(rid), int
* Landlord ID(lid), int
* Username(username), string
* Password(passwd), string
* Remember login(rememb_login), bool

#### Table 4 (Signup)
* Roommate ID(rid), int
* Landlord ID(lid), int
* Name(name), string
* Username(username), string
* Password(passwd), string
* Email(email), string
* Creation date(created_at), date
* Gender(gender), bool
* Address(addr), string
* State(state), string
* Country(country), string
* ZIP Code(zip), int

<a name="primary-keys"></a>
# Primary Keys

#### Table 1 (Roommate)
* Roommate ID(rid)

#### Table 2 (LandLord)
* Landlord ID(lid)

#### Table 3 (Login)
* Roommate ID(rid)
* Landlord ID(lid)
* Username(username)

#### Table 4 (Signup)
* Only foreign Keys

<a name="foreign-keys"></a>
# Foreign Keys

#### Table 1 (Roommate)
* Username(username)

#### Table 2 (LandLord)
* Username(username)

#### Table 3 (Login)
No Foreign Keys

#### Table 4 (Signup)
* Roommate ID(rid)
* Landlord ID(lid)
* Username(username)

<a name="fd"></a>
# Function Dependencies

#### Table 1 (Roommate)
* rid -> name, username, passwd, email, created_at, gender, addr, state, country, Zip
* username -> rid, name, passwd, email, created_at, gender, addr, state, country, Zip
* email -> rid, name, passwd, email, created_at, gender, addr, state, country, Zip
* passwd -> username
* name, addr -> state, country, Zip
* Zip -> state, country

#### Table 2 (LandLord)
* lid -> name, username, passwd, email, created_at, gender, addr, state, country, Zip
* username -> lid, name, passwd, email, created_at, gender, addr, state, country, Zip
* email -> lid, name, passwd, email, created_at, gender, addr, state, country, Zip
* passwd -> username
* name, addr -> state, country, zip
* Zip -> state, country

#### Table 3 (Login)
* username -> rid, lid, passwd, rememb_login
* lid, passwd -> username, rememb_login
* rid, passwd -> username, rememb_login
* rid, lid -> username, passwd, rememb_login

#### Table 4 (Signup)
* rid, lid -> name, username, passwd, email, created_at, gender, addr, state, country, Zip
* username -> rid, lid, passwd, email, created_at, gender, addr, state, country, Zip
* email -> rid, lid, name, username, passwd, email, create_at, gender, addr, state, country, Zip
* passwd -> username
* name, addr -> state, country, Zip
* Zip -> state, country


<a name="trigger"></a>
# Triggers and Policies

* The triggers and policies in my database are mostly requirements for field input and auto generation of derived information. Tables 1 and 2 only store information provided from the signup and login data tables.

#### Table 1 (Roommate)
* Update table with passwd hash to secure information.

#### Table 2 (Landlord)
* Update table with passwd hash to secure information.

#### Table 3 (Login)
* Require username.
* Require passwd.
* Update table with passwd hash to secure information.
* Auto generate rememb_login based off radio button selection. Boolean value.


#### Table 4 (Signup)
* Auto generate rid or lid based on radio button selection for a roommate or landlord. Pick next lowest number in the rid, lid stack.
* Require name.
* Require username.
* Require passwd.
* * Update table with passwd hash to secure information.
* Require email.
* Auto generate Creation Date under the hood when user submits signup form. This will pull date from interview OS and place it in the creation_at column.
* Auto generate Zip code for combination of Address, State, Country, if not provided.


<a name="3nf"></a>
# 3NF

* The database I have created for my senior design project is in 3NF. This is because I followed the 2 Rules of 3NF.
1. The LHS of each FD is a Super Key.
2. The RHS is a Prime attribute.
3. The relational database is in 2NF.

<a name="sample-data"></a>
# Sample Data

![image](https://user-images.githubusercontent.com/74672038/205476774-03ed126c-13b3-4b93-a239-9c25a33f68aa.png)


![image](https://user-images.githubusercontent.com/74672038/205476765-11b4740e-70a8-43ff-bbf5-0747db76e615.png)


![image](https://user-images.githubusercontent.com/74672038/205476782-7eb1399a-6ab8-418b-8d34-0bcc1574d9fc.png)


![image](https://user-images.githubusercontent.com/74672038/205476964-aff1ee6f-c1e9-43b3-a79e-e61be808e8bc.png)

