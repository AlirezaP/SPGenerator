
namespace SPGenarator
{
    class Query
    {
       static public string InsBody = @"
INSERT INTO ##tbName##
(
##col##
)
VALUES
(
##val##
)";

        static public string UpdBody = @"
UPDATE ##tbName##
set ##UPMethod##
##Condition##
";

        static public string ListBody = @"
Select ##colName## from ##tbName##
";

        static public string DelBody = @"
Delete from ##tbName## 
##Condition##
";


        static public string SpBody =
@"
CREATE PROCEDURE ##PreFix##_##tbName##
##param##
AS
BEGIN
##body##
END
";

        static public string SelSpBody =
@"
CREATE PROCEDURE ##PreFix##_##tbName##
##param##
AS
BEGIN
##body##
END
";

        static public string UpdSpBody =
@"
CREATE PROCEDURE ##PreFix##_##tbName##
##param##
AS
BEGIN
##body##
END
";

        static public string DelSpBody =
@"
CREATE PROCEDURE ##PreFix##_##tbName##
##param##
AS
BEGIN
##body##
END
";


    }
}
