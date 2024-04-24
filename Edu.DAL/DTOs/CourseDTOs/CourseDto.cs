﻿using Edu.Domain.Models;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Edu.DAL.DTOs.CourseDTOs;

public class CourseDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("student_id")]
    public int SubjectId { get; set; }
    [JsonPropertyName("subject")]
    public Subject Subject { get; set; }
    [JsonPropertyName("teacher_id")]
    public int TeacherId { get; set; }
    [JsonPropertyName("teacher")]
    public DateTimeOffset StartingDate { get; set; }
    [JsonPropertyName("price")]
    public decimal Price { get; set; }
    [JsonPropertyName("students")]
    public Collection<Student> Students { get; set; }
}