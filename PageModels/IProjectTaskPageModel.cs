using CommunityToolkit.Mvvm.Input;
using XmlnsSimple.Models;

namespace XmlnsSimple.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}