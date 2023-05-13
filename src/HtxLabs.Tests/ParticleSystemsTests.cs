using System.Numerics;
using HtxLabs.Models;

namespace HtxLabs.Tests;

public class ParticleSystemsTests
{
    [Fact]
    public void CreateParticleGroup_ValidTypeIDAndSetPropertiesCorrectly_Success()
    {
        // Arrange
        var particleGroup = new ParticleGroup(1); 

        // Act

        // Assert
    }

    [Fact]
    public void AttachParticleGroupToModel_PositionAndOrientationMatchModel_Success()
    {
        // Arrange

        // Act

        // Assert
    }

    [Fact]
    public void PlaceParticleGroupAtLocation_PositionAndOrientationNotAffected_Success()
    {
        // Arrange

        // Act

        // Assert
    }

    [Fact]
    public void PlaceParticleGroupInScreenSpace_PositionAndOrientationNotAffected_Success()
    {
        // Arrange

        // Act

        // Assert
    }

    [Fact]
    public void ScaleParticleGroup_ScaleAppliedWithoutAffectingPositionAndOrientation_Success()
    {
        // Arrange

        // Act

        // Assert
    }

    [Fact]
    public void RotateParticleGroup_PostionAndOrientationUpdated_Success()
    {
        // Arrange

        // Act

        // Assert
    }

    [Fact]
    public void EndParticleGroup_RemoveParticleGroupFromActiveGroups_Success()
    {
        // Arrange

        // Act

        // Assert
    }

    [Fact]
    public void CreateParticleGroupWithInvalidID_ThrowsException_Failure()
    {
        // Arrange

        // Act

        // Assert
    }

    [Fact]
    public void AttachParticleGroupToInvalidModel_ThrowsException_Failure()
    {
        // Arrange

        // Act

        // Assert
    }

    [Fact]
    public void EndInactvieParticle_ThrowsException_Failure()
    {
        // Arrange

        // Act

        // Assert
    }
}
