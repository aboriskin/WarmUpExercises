using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebSite.Migrations
{
    public partial class UpdateExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Css",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Html",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Javascript",
                table: "Exercises");

            migrationBuilder.AddColumn<string>(
                name: "AnswerCss",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnswerHtml",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnswerJavascript",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IncludeCssTab",
                table: "Exercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IncludeHtmlTab",
                table: "Exercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IncludeJavascriptTab",
                table: "Exercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "StartCss",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartHtml",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartJavascript",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerCss",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "AnswerHtml",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "AnswerJavascript",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "IncludeCssTab",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "IncludeHtmlTab",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "IncludeJavascriptTab",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "StartCss",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "StartHtml",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "StartJavascript",
                table: "Exercises");

            migrationBuilder.AddColumn<string>(
                name: "Css",
                table: "Exercises",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Html",
                table: "Exercises",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Javascript",
                table: "Exercises",
                nullable: true);
        }
    }
}
