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

* My database is based off of my Senior Design project Roomers. Roomers is a web-based application to ease the frustrations of having a roommate.
* The general requires for this database is to fufill basic requirements of our site. Our three major features for this application are...

  1. A financial tab that helps roommates navigate splitting, paying, and staying on time with bills.
  2. A calender tab that will sync roommates calendars to allow eachother to know when others will be home, when they have class, and other general calender information.
  3. A communication system that will allow roommate to roommate as well as roommate to landlord communication. This will ease the stress of giving out personal information such as cell phones numbers but allow open communication throughout the household.

* The layout of my database will be wildly based of off general personal information, log in, and sign up details. As this is an exstensive data for the whole project I will focus strictly on betting the intial user databases for the CS665 Project.

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
* Sign up table will bwe utilized for roommates or landlords to be able to sign up for the first time. The table will have a Roommate ID(rid), Landlord ID(lid), Name(name), Username(username), Password(passwd), Email(email), Creation date(created_at), Gender(gender), Address(addr), State(state), Country(country).

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
# Function Dependancies

<a name="trigger"></a>
# Triggers and Policies

<a name="3nf"></a>
# 3NF

<a name="sample-data"></a>
# Sample Data
