USE [ModernMarketResearch]
GO
/****** Object:  Table [dbo].[RoleMaster]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleMaster](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[IsValid] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_RoleMaster] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleActionRelation]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleActionRelation](
	[RAId] [int] IDENTITY(1,1) NOT NULL,
	[RId] [int] NOT NULL,
	[AId] [int] NOT NULL,
 CONSTRAINT [PK_RoleActionRelation] PRIMARY KEY CLUSTERED 
(
	[RAId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReportType]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportType](
	[ReportTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ReportType] [nvarchar](10) NULL,
 CONSTRAINT [PK_ReportType] PRIMARY KEY CLUSTERED 
(
	[ReportTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReportMaster]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportMaster](
	[ReportId] [int] IDENTITY(1,1) NOT NULL,
	[ReportTitle] [nvarchar](2000) NOT NULL,
	[ReportUrl] [nvarchar](350) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[PublishereId] [int] NOT NULL,
	[PublishingDate] [datetime] NOT NULL,
	[MetaTitle] [nvarchar](2000) NULL,
	[MetaDescription] [text] NULL,
	[Keywords] [nvarchar](500) NULL,
	[SinglePrice] [decimal](18, 0) NOT NULL,
	[MultiUserPrice] [decimal](18, 0) NULL,
	[CorporateUserPrice] [decimal](18, 0) NULL,
	[Domain] [nvarchar](50) NULL,
	[ReportDeliveryTypeId] [int] NOT NULL,
	[ReportTypeId] [int] NOT NULL,
	[ReportImage] [nvarchar](500) NULL,
	[NumberOfPages] [int] NOT NULL,
	[ShortDescription] [text] NULL,
	[LongDescritpion] [text] NULL,
	[TableOfContent] [text] NULL,
	[ListOfCharts] [text] NULL,
	[ListOfFigure] [text] NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_ReportMaster] PRIMARY KEY CLUSTERED 
(
	[ReportId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReportDeliveryType]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportDeliveryType](
	[ReportDeliveryTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ReportDeliveryType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ReportDeliveryType] PRIMARY KEY CLUSTERED 
(
	[ReportDeliveryTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublisherMaster]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublisherMaster](
	[PublisherId] [int] IDENTITY(1,1) NOT NULL,
	[PublisherName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[PublisherContactNumber] [nvarchar](50) NOT NULL,
	[publisherUrl] [nvarchar](50) NULL,
	[Keywords] [nvarchar](50) NULL,
	[LongDescription] [nvarchar](50) NULL,
	[ShortDescription] [nvarchar](50) NULL,
	[MetaDescription] [nvarchar](50) NULL,
	[ContactName] [nvarchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[IsValid] [bit] NULL,
 CONSTRAINT [PK_PublisherMaster] PRIMARY KEY CLUSTERED 
(
	[PublisherId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewsMaster]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewsMaster](
	[NewsId] [int] IDENTITY(1,1) NOT NULL,
	[NewsTitle] [nvarchar](2550) NOT NULL,
	[NewsUrl] [nvarchar](500) NULL,
	[CategoryId] [int] NOT NULL,
	[NewsDescription] [text] NOT NULL,
	[PublishingDate] [datetime] NOT NULL,
	[MetaTitle] [nvarchar](750) NULL,
	[MetaDescritpion] [text] NULL,
	[Keywords] [nvarchar](550) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_NewsMaster] PRIMARY KEY CLUSTERED 
(
	[NewsId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerInquiry]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerInquiry](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[EmailId] [nvarchar](50) NOT NULL,
	[Designation] [nvarchar](50) NULL,
	[Company] [nvarchar](50) NULL,
	[CaptchaCode] [nvarchar](50) NOT NULL,
	[CustomerMessage] [text] NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](15) NULL,
	[ReportId] [int] NULL,
	[FormType] [nvarchar](10) NULL,
	[ReportTitle] [nvarchar](50) NULL,
	[AreaCode] [nvarchar](10) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_CustomerInquiry] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[iso] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[nicename] [nvarchar](50) NOT NULL,
	[iso3] [nvarchar](50) NULL,
	[numcode] [nvarchar](50) NULL,
	[phonecode] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryMaster]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryMaster](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[ParentCategoryId] [int] NULL,
	[ShortDescription] [nvarchar](50) NULL,
	[LongDescription] [nvarchar](50) NULL,
	[CategoryUrl] [nvarchar](50) NOT NULL,
	[MetaTitle] [nvarchar](50) NULL,
	[Keywords] [nvarchar](50) NULL,
	[IsActive] [bit] NOT NULL,
	[MetaDescription] [nvarchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BuyingInfo]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuyingInfo](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[EmailId] [nvarchar](50) NOT NULL,
	[Designation] [nvarchar](50) NOT NULL,
	[Company] [nvarchar](50) NOT NULL,
	[CaptchaCode] [nvarchar](50) NOT NULL,
	[CustomerMessage] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Type] [nchar](10) NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Zipcode] [nvarchar](50) NOT NULL,
	[Paymentmode] [nvarchar](50) NOT NULL,
	[AreaCode] [nvarchar](50) NOT NULL,
	[IPAddress] [nvarchar](50) NOT NULL,
	[GuId] [nvarchar](50) NOT NULL,
	[ReportUrl] [nvarchar](50) NOT NULL,
	[TransactionId] [nvarchar](50) NOT NULL,
	[ReportTitle] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BuyingInfo] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActionMaster]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActionMaster](
	[ActionId] [int] IDENTITY(1,1) NOT NULL,
	[ActionName] [nvarchar](50) NOT NULL,
	[IsValid] [bit] NOT NULL,
 CONSTRAINT [PK_ActionMaster] PRIMARY KEY CLUSTERED 
(
	[ActionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoleRelation]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoleRelation](
	[UserRoleId] [int] IDENTITY(1,1) NOT NULL,
	[URoleId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_UserRoleRelation] PRIMARY KEY CLUSTERED 
(
	[UserRoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserMaster]    Script Date: 07/28/2018 09:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserMaster](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserFName] [nvarchar](50) NOT NULL,
	[UserLName] [nvarchar](50) NOT NULL,
	[CurrentAddress] [nvarchar](50) NOT NULL,
	[EmailAddress] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[State] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[ContactNumber] [nvarchar](50) NOT NULL,
	[PermnentAddress] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_UserMaster] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[SplitString]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[SplitString](@StringToSplit varchar(max)) 

RETURNS @Returnlist table([Name] [nvarchar](500))
AS
BEGIN
	-- Declare the return variable here
	DECLARE @name nvarchar(500)
	Declare @pos int
WHILE CHARINDEX(',',@StringToSplit)>0
 BEGIN
            select @pos=CHARINDEX(',',@StringToSplit)
            select @name=SUBSTRING(@StringToSplit,1,@pos-1)
            
            Insert Into @Returnlist 
            select @name
            
            select @StringToSplit=SUBSTRING(@StringToSplit,@pos+1,LEN(@StringToSplit)-@pos)
           
 END
	-- Return the result of the function
	Insert Into @Returnlist
	SELECT @StringToSplit
	RETURN 

END
GO
/****** Object:  StoredProcedure [dbo].[spLatestReport]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLatestReport]
AS
BEGIN 
Select top 6  
R.ReportId,
R.ReportTitle,
R.ReportUrl,
R.PublishingDate,
R.LongDescritpion,
R.SinglePrice,
C.CategoryName,
P.PublisherId,
P.PublisherName

From ReportMaster R
join CategoryMaster C on R.CategoryId=C.CategoryId
join PublisherMaster P on R.PublishereId=P.PublisherId
Order by R.ReportId Desc
END
GO
/****** Object:  StoredProcedure [dbo].[spLatestNews]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLatestNews]
AS
BEGIN 
Select top 5  
N.NewsId,
N.NewsTitle,
N.NewsUrl,
N.PublishingDate,
SUBSTRING(N.NewsDescription,0,300)as LongDescription,
C.CategoryId,
C.CategoryName,
C.CategoryUrl

From NewsMaster N
join CategoryMaster C on N.CategoryId=C.CategoryId

Order by N.NewsId Desc
END
GO
/****** Object:  StoredProcedure [dbo].[spDetailsUserRole]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDetailsUserRole] @UserId int
AS
BEGIN 
 select distinct UM.UserFName,
 UR2.UserId,
 SUBSTRING(( select ','+ RM.RoleName
from RoleMaster RM 
join UserRoleRelation UR on RM.RoleId=UR.URoleId
WHERE UR.URoleId=RM.RoleId
order by UR.UserId
 FOR XML PATH ('')),2,1000) AS UserRole
 from UserRoleRelation UR2
 join UserMaster UM on UR2.UserId=UM.UserId
join RoleMaster RM2 on UR2.URoleId=RM2.RoleId
Where UM.UserId=@UserId
END
GO
/****** Object:  StoredProcedure [dbo].[spDetailsRoleAction]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDetailsRoleAction] @RoleId int
AS
BEGIN 
 select distinct RM.RoleName,
 RA2.RId,
 SUBSTRING(( select ','+ Am.ActionName
from ActionMaster AM 
join RoleActionRelation RA on AM.ActionId =RA.AId
WHERE RA.RId=RA2.RId
order by RA.RId
 FOR XML PATH ('')),2,1000) AS RoleAction
 from RoleActionRelation RA2
 join RoleMaster RM on RA2.RId=RM.RoleId
join ActionMaster AM2 on RA2.AId=AM2.ActionId
Where RM.RoleId=@RoleId
END
GO
/****** Object:  StoredProcedure [dbo].[spCategoryRelatedReport]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spCategoryRelatedReport](@Catid int,@Pageno int,@P_Count int output )
AS
BEGIN 
Declare @id int;
Declare @PageSize int;
Set @PageSize=10;
Declare @TempTable Table (id int NOT NULL)
;WITH Parent AS
(
select CategoryId,
       ParentCategoryId
       from CategoryMaster
       Where CategoryId=@id
       Union ALL
       select t.CategoryId,
              t.ParentCategoryId
       from Parent
       Inner Join CategoryMaster t on t.CategoryId=parent.ParentCategoryId
)      
     insert into @TempTable 
     select top 1 CategoryId
     from Parent
     order by CategoryId asc
     declare @RelatedCategories Table(id int not null)
     
     ;WITH rCTE AS(
     select CategoryId,
            ParentCategoryId
            from CategoryMaster
            Where CategoryId=@id
            UNION ALL
            SELECT t.CategoryId,
                   t.ParentCategoryId
                   from rCTE
                   Inner Join CategoryMaster t on t.ParentCategoryId=rCTE.CategoryId
)
  Insert into @RelatedCategories
  select CategoryId from rCTE OPTION(MAXRECURSION 0);
  select @P_Count=COUNT(ReportId) 
  from ReportMaster rm Where 
  rm.CategoryId IN(select id from @RelatedCategories);  
  select            
                    ReportTitle,
                    CategoryId,
                    ReportUrl,
                    CategoryName,
                    PublishingDate,
                    LongDescription,
                    NumberOfPages,
                    ReportId,
                    SinglePrice,
                    ShortDescription,
                    TableOfContent,
                    MetaTitle,
                    MetaDescription,
                    Keywords,
                    MultiUserPrice,
                    CorporateUserPrice,
                    ReportTypeId,
                    ReportImage,
                    CategoryUrl,
                    PublisherName 


  from (select 
                    ROW_NUMBER() OVER (ORDER BY R.CreatedDate Desc)as Row,
                    R.ReportTitle,
                    R.CategoryId,
                    R.ReportUrl,
                    C.CategoryName,
                    CONVERT(nvarchar(11),R.PublishingDate,106)as PublishingDate,
                    SUBSTRING(R.LongDescritpion,0,300)as LongDescription,
                    R.NumberOfPages,
                    R.ReportId,
                    R.SinglePrice,
                    R.ShortDescription,
                    R.TableOfContent,
                    R.MetaTitle,
                    R.MetaDescription,
                    R.Keywords,
                    R.MultiUserPrice,
                    R.CorporateUserPrice,
                    R.ReportTypeId,
                    R.ReportImage,
                    C.CategoryUrl,
                    P.PublisherName                    
                    from ReportMaster R
                    join CategoryMaster c on R.CategoryId=c.CategoryId
                    join PublisherMaster P on R.PublishereId=P.PublisherId
                    Where R.CategoryId IN(select id from @RelatedCategories))as T
                    Where T.Row BETWEEN ((@Pageno-1)*@PageSize+1)AND (@Pageno*@PageSize)              

     

END
GO
/****** Object:  StoredProcedure [dbo].[spBreadsCum]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spBreadsCum] (@CategoryId int)
AS
BEGIN 
Declare @ID int;
Declare @CatId int;
Set @ID=@CatId;
Declare @X AS TABLE (id int)
Insert into @X
Select @ID
While(@ID>0)
Begin
Select @ID=ParentCategoryId 
From CategoryMaster
Where CategoryId=@ID
Insert into @X
Select @ID
End
Select C.CategoryId,
       C.CategoryName,
       C.CategoryUrl
From @X x
Inner Join CategoryMaster C on x.id=C.CategoryId
Order By C.CategoryId asc
END
GO
/****** Object:  StoredProcedure [dbo].[spUserRoleUpdate]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUserRoleUpdate] 
                        @UserId int,
                        @UserFName nvarchar(200),
                        @UserLName nvarchar(50) ,
                        @CurrentAddress nvarchar(50),
                        @State nvarchar(50), 
                        @City nvarchar(100),
                        @ContactNumber nvarchar(100),
                        @PermnentAddress nvarchar(100),
                        @Gender nvarchar(50),
                        @CompanyName nvarchar(50),
                        @EmailAddress nvarchar(50),
                        @Password nvarchar (50),
                        @IsActive bit,
                        @CreatedBy int,  
                        @ModifiedBy int,
                        @CreatedDate DateTime,
                        @ModifiedDate DateTime,
                        @RoleId nvarchar(200)
AS
BEGIN
Delete from UserMaster
Where UserId=@UserId
Delete from UserRoleRelation
where UserId=@UserId

INSERT INTO [ModernMarketResearch].[dbo].[UserMaster]
           ([UserFName]
           ,[UserLName]
           ,[CurrentAddress]
           ,[EmailAddress]
           ,[Password]
           ,[IsActive]
           ,[State]
           ,[City]
           ,[ContactNumber]
           ,[PermnentAddress]
           ,[Gender]
           ,[CompanyName]
           ,[CreatedBy]
           ,[CreatedDate]
           ,[ModifiedBy]
           ,[ModifiedDate])
     VALUES
           (@UserFName
           ,@UserLName
           ,@CurrentAddress
           ,@EmailAddress
           ,@Password
           ,@IsActive
           ,@State
           ,@City
           ,@ContactNumber
           ,@PermnentAddress
           ,@Gender
           ,@CompanyName
           ,@CreatedBy
           ,@CreatedDate
           ,@ModifiedBy
           ,@ModifiedDate)
 
 Declare @PK int 
 SET @PK =SCOPE_IDENTITY()         
 Insert INTO UserRoleRelation(UserId,URoleId)
 Select @PK UserId,
 CAST(Name as int)
 FROM SplitString(@RoleId)
 
 
           

END
GO
/****** Object:  StoredProcedure [dbo].[spUserRoleSelect]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[spUserRoleSelect]
AS
BEGIN 
 select distinct UM.UserFName,
 UM.UserId,
 SUBSTRING(( select ','+ RM.RoleName
from RoleMaster RM 
join UserRoleRelation UR on RM.RoleId =UR.URoleId
WHERE UR.URoleId=RM.RoleId
order by UR.UserId
 FOR XML PATH ('')),2,1000) AS UserRole
 from UserRoleRelation UR2
 join UserMaster UM on UR2.UserId=UM.UserId
join RoleMaster RM2 on UR2.URoleId=RM2.RoleId
END
GO
/****** Object:  StoredProcedure [dbo].[spUserRoleInsert]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUserRoleInsert] 
                        @UserId int,
                        @UserFName nvarchar(200),
                        @UserLName nvarchar(50) ,
                        @CurrentAddress nvarchar(50),
                        @State nvarchar(50), 
                        @City nvarchar(100),
                        @ContactNumber nvarchar(100),
                        @PermnentAddress nvarchar(100),
                        @Gender nvarchar(50),
                        @CompanyName nvarchar(50),
                        @EmailAddress nvarchar(50),
                        @Password nvarchar (50),
                        @IsActive bit,
                        @CreatedBy int,  
                        @ModifiedBy int,
                        @CreatedDate DateTime,
                        @ModifiedDate DateTime,
                        @RoleId nvarchar(200)
AS
BEGIN
INSERT INTO [ModernMarketResearch].[dbo].[UserMaster]
           ([UserFName]
           ,[UserLName]
           ,[CurrentAddress]
           ,[EmailAddress]
           ,[Password]
           ,[IsActive]
           ,[State]
           ,[City]
           ,[ContactNumber]
           ,[PermnentAddress]
           ,[Gender]
           ,[CompanyName]
           ,[CreatedBy]
           ,[CreatedDate]
           ,[ModifiedBy]
           ,[ModifiedDate])
     VALUES
           (@UserFName
           ,@UserLName
           ,@CurrentAddress
           ,@EmailAddress
           ,@Password
           ,@IsActive
           ,@State
           ,@City
           ,@ContactNumber
           ,@PermnentAddress
           ,@Gender
           ,@CompanyName
           ,@CreatedBy
           ,@CreatedDate
           ,@ModifiedBy
           ,@ModifiedDate)

 
 Declare @PK int 
 SET @PK =SCOPE_IDENTITY()         
 Insert INTO UserRoleRelation(UserId,URoleId)
 Select @PK UserId,
 CAST(Name as int)
 FROM SplitString(@RoleId)
 
 
           

END
GO
/****** Object:  StoredProcedure [dbo].[spUserRoleDelete]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[spUserRoleDelete] 
                        @UserId int 
                        
AS
BEGIN
Delete from UserMaster
Where UserId=@UserId

Delete from UserRoleRelation
where UserId=UserId

END
GO
/****** Object:  StoredProcedure [dbo].[spSelectRoleAction]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSelectRoleAction]
AS
BEGIN 
 select distinct RM.RoleName,
 RA2.RId,
 SUBSTRING(( select ','+ Am.ActionName
from ActionMaster AM 
join RoleActionRelation RA on AM.ActionId =RA.AId
WHERE RA.RId=RA2.RId
order by RA.RId
 FOR XML PATH ('')),2,1000) AS RoleAction
 from RoleActionRelation RA2
 join RoleMaster RM on RA2.RId=RM.RoleId
join ActionMaster AM2 on RA2.AId=AM2.ActionId
END
GO
/****** Object:  StoredProcedure [dbo].[spSelectedNewsDetails]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectedNewsDetails] @NewsUrl nvarchar(50)
AS
BEGIN
Select 
N.NewsId,
N.NewsTitle,
N.NewsDescription,
N.NewsUrl,
C.CategoryId,
C.CategoryName,
C.CategoryUrl,
N.PublishingDate

from NewsMaster N
Join CategoryMaster C on N.CategoryId =C.CategoryId
Where N.NewsUrl=@NewsUrl
END
GO
/****** Object:  StoredProcedure [dbo].[spRoleActionUpdate]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRoleActionUpdate] 
                        @RoleId int ,
                        @RoleName nvarchar(200),
                        @IsActive bit ,
                        @CreatedBy int,
                        @ModifiedBy int,
                        @CreatedDate DateTime,
                        @ModifiedDate DateTime,
                        @ActionId nvarchar(200)
AS
BEGIN
Delete from RoleMaster
Where RoleId=@RoleId
Delete from RoleActionRelation
where RId=@RoleId

INSERT INTO RoleMaster
           ([RoleName]
           ,[IsValid] 
           ,[CreatedBy]
           ,[ModifiedBy]
           ,[CreatedDate] 
           ,[ModifiedDate] )
     VALUES
           (@RoleName
           ,@IsActive
           ,@CreatedBy
           ,@ModifiedBy 
           ,@CreatedDate
           ,@ModifiedDate)
 
 Declare @PK int 
 SET @PK =SCOPE_IDENTITY()         
 Insert INTO RoleActionRelation(RId,AId)
 Select @PK RId,
 CAST(Name as int)
 FROM SplitString(@ActionId)
 
 
           

END
GO
/****** Object:  StoredProcedure [dbo].[spRoleActionInsert]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRoleActionInsert] 
                        @RoleId int ,
                        @RoleName nvarchar(200),
                        @IsActive bit ,
                        @CreatedBy int,
                        @ModifiedBy int,
                        @CreatedDate DateTime,
                        @ModifiedDate DateTime,
                        @ActionId nvarchar(200)
AS
BEGIN
INSERT INTO RoleMaster
           ([RoleName]
           ,[IsValid] 
           ,[CreatedBy]
           ,[ModifiedBy]
           ,[CreatedDate] 
           ,[ModifiedDate] )
     VALUES
           (@RoleName
           ,@IsActive
           ,@CreatedBy
           ,@ModifiedBy 
           ,@CreatedDate
           ,@ModifiedDate)
 
 Declare @PK int 
 SET @PK =SCOPE_IDENTITY()         
 Insert INTO RoleActionRelation(RId,AId)
 Select @PK RId,
 CAST(Name as int)
 FROM SplitString(@ActionId)
 
 
           

END
GO
/****** Object:  StoredProcedure [dbo].[spRoleActionDelete]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRoleActionDelete] 
                        @RoleId int 
                        
AS
BEGIN
Delete from RoleMaster
Where RoleId=@RoleId

Delete from RoleActionRelation
where RId=@RoleId

END
GO
/****** Object:  StoredProcedure [dbo].[spNewAllLatestReport]    Script Date: 07/28/2018 09:58:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spNewAllLatestReport] (@Pageno int,@P_Count int output ) 
AS
BEGIN
Declare @PageSize int;
--Declare @Pageno int;
Set @PageSize=10; 
--Set @Pageno=1;
 select @P_Count=COUNT(ReportId) 
  from ReportMaster
 select            
                    ReportTitle,
                    CategoryId,
                    ReportUrl,
                    CategoryName,
                    PublishingDate,
                    LongDescription,
                    NumberOfPages,
                    ReportId,
                    SinglePrice,
                    ShortDescription,
                    TableOfContent,
                    MetaTitle,
                    MetaDescription,
                    Keywords,
                    MultiUserPrice,
                    CorporateUserPrice,
                    ReportTypeId,
                    ReportImage,
                    CategoryUrl,
                    PublisherName,
                    PublisherId,
                    publisherUrl 


  from (select 
                    ROW_NUMBER() OVER (ORDER BY R.CreatedDate Desc)as Row,
                    R.ReportTitle,
                    R.CategoryId,
                    R.ReportUrl,
                    C.CategoryName,
                    CONVERT(nvarchar(11),R.PublishingDate,106)as PublishingDate,
                    SUBSTRING(R.LongDescritpion,0,300)as LongDescription,
                    R.NumberOfPages,
                    R.ReportId,
                    R.SinglePrice,
                    R.ShortDescription,
                    R.TableOfContent,
                    R.MetaTitle,
                    R.MetaDescription,
                    R.Keywords,
                    R.MultiUserPrice,
                    R.CorporateUserPrice,
                    R.ReportTypeId,
                    R.ReportImage,
                    C.CategoryUrl,
                    P.PublisherName,
                    P.PublisherId,
                    P.publisherUrl                    
                    from ReportMaster R
                    join CategoryMaster c on R.CategoryId=c.CategoryId
                    join PublisherMaster P on R.PublishereId=P.PublisherId
)as T
                    Where T.Row BETWEEN ((@Pageno-1)*@PageSize+1)AND (@Pageno*@PageSize)              

END
GO
