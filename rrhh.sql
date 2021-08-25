/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     06/05/2014 16:17:47                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MOTIVO') and o.name = 'FK_MOTIVO_DETUSO_EMPLEADO')
alter table MOTIVO
   drop constraint FK_MOTIVO_DETUSO_EMPLEADO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USODIAS') and o.name = 'FK_USODIAS_DETRABAJA_EMPLEADO')
alter table USODIAS
   drop constraint FK_USODIAS_DETRABAJA_EMPLEADO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLEADO')
            and   type = 'U')
   drop table EMPLEADO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MOTIVO')
            and   name  = 'DETUSO_FK'
            and   indid > 0
            and   indid < 255)
   drop index MOTIVO.DETUSO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MOTIVO')
            and   type = 'U')
   drop table MOTIVO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USODIAS')
            and   name  = 'DETRABAJADO_FK'
            and   indid > 0
            and   indid < 255)
   drop index USODIAS.DETRABAJADO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USODIAS')
            and   type = 'U')
   drop table USODIAS
go

/*==============================================================*/
/* Table: EMPLEADO                                              */
/*==============================================================*/
create table EMPLEADO (
   RUT                  int                  not null,
   DV                   text                 null,
   NOMBRE               text                 null,
   APATERNO             text                 null,
   AMATERNO             text                 null,
   CARGO                text                 null,
   SUCURSAL             text                 null,
   FECHASOLICITUD       datetime             null,
   constraint PK_EMPLEADO primary key nonclustered (RUT)
)
go

/*==============================================================*/
/* Table: MOTIVO                                                */
/*==============================================================*/
create table MOTIVO (
   DIASUSADOS           int                  null,
   MOTIVODETALLE        text                 null,
   IDDIASUSADOS         int                  not null,
   RUT                  int                  not null,
   constraint PK_MOTIVO primary key nonclustered (IDDIASUSADOS)
)
go

/*==============================================================*/
/* Index: DETUSO_FK                                             */
/*==============================================================*/
create index DETUSO_FK on MOTIVO (
RUT ASC
)
go

/*==============================================================*/
/* Table: USODIAS                                               */
/*==============================================================*/
create table USODIAS (
   DESDE                datetime             null,
   HASTA                datetime             null,
   IDDIASTRABAJADOS     int                  not null,
   RUT                  int                  not null,
   constraint PK_USODIAS primary key nonclustered (IDDIASTRABAJADOS)
)
go

/*==============================================================*/
/* Index: DETRABAJADO_FK                                        */
/*==============================================================*/
create index DETRABAJADO_FK on USODIAS (
RUT ASC
)
go

alter table MOTIVO
   add constraint FK_MOTIVO_DETUSO_EMPLEADO foreign key (RUT)
      references EMPLEADO (RUT)
go

alter table USODIAS
   add constraint FK_USODIAS_DETRABAJA_EMPLEADO foreign key (RUT)
      references EMPLEADO (RUT)
go

