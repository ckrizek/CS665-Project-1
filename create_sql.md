# Create SQL

<a name="contents"></a>
## Contents

* [SQL Creation Statements](#sql-statement)

***

<a name="sql-statement"></a>
## SQL Creation Statements

* The following are my table creation SQL statements.

* Table 1 (roommate)

```
CREATE TABLE "roommate" (
	"rid"	INTEGER,
	"name"	TEXT,
	"username"	TEXT,
	"passwd"	INTEGER,
	"email"	TEXT,
	"created_at"	NUMERIC,
	"gender"	INTEGER,
	"addr"	TEXT,
	"state"	TEXT,
	"country"	TEXT,
	"Zip"	INTEGER,
	PRIMARY KEY("rid")
);
```

* Table 2 (landlord)

```
CREATE TABLE "landlord" (
	"lid"	INTEGER,
	"name"	TEXT NOT NULL,
	"username"	TEXT NOT NULL,
	"passwd"	TEXT NOT NULL,
	"email"	TEXT,
	"created_at"	REAL,
	"gender"	TEXT,
	"addr"	TEXT NOT NULL,
	"state"	TEXT NOT NULL,
	"country"	TEXT NOT NULL,
	"zip"	INTEGER NOT NULL,
	PRIMARY KEY("lid")
);
```

* Table 3 (login)

```
CREATE TABLE "login" (
	"rid"	INTEGER,
	"lid"	INTEGER,
	"username"	TEXT NOT NULL,
	"passwd"	TEXT NOT NULL,
	"rememb_login"	INTEGER,
	FOREIGN KEY("rid") REFERENCES "roommate",
	PRIMARY KEY("username")
);
```

* Table 4 (signup)

```
CREATE TABLE "signup" (
	"rid"	INTEGER,
	"lid"	INTEGER,
	"name"	TEXT NOT NULL,
	"username"	TEXT NOT NULL,
	"password"	TEXT NOT NULL,
	"email"	TEXT,
	"creation_at"	NUMERIC,
	"gender"	TEXT,
	"addr"	TEXT NOT NULL,
	"state"	TEXT NOT NULL,
	"country"	TEXT NOT NULL,
	"zip"	INTEGER NOT NULL,
	FOREIGN KEY("username") REFERENCES "login",
	FOREIGN KEY("rid") REFERENCES "roommate",
	PRIMARY KEY("name")
);
```
