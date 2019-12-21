using openrmf_save_api.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace openrmf_save_api.Data {
    public interface IArtifactRepository
    {
        Task<IEnumerable<Artifact>> GetAllArtifacts();

        Task<Artifact> GetArtifact(string id);

        // query after multiple parameters
        Task<IEnumerable<Artifact>> GetArtifact(string bodyText, DateTime updatedFrom, long headerSizeLimit);
        
        // get all artifacts based on the system ID
        Task<IEnumerable<Artifact>> GetSystemArtifacts(string system);

        // add new note document
        Task<Artifact> AddArtifact(Artifact item);

        // update just a single document
        Task<bool> UpdateArtifact(string id, Artifact body);

        Task<bool> DeleteArtifact(string id);
    }
}